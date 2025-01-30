CREATE TABLE t_users (
    c_user_id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    c_first_name VARCHAR(255) NOT NULL,
    c_last_name VARCHAR(255) NOT NULL,
    c_email VARCHAR(255) UNIQUE NOT NULL,
    c_password TEXT NOT NULL,
    c_date_created TIMESTAMP NOT NULL DEFAULT NOW(),
    c_date_updated TIMESTAMP NOT NULL DEFAULT NOW(),
    c_is_active BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE t_transactions (
    c_transaction_id UUID PRIMARY KEY DEFAULT gen_random_uuid(),
    c_user_id UUID NOT NULL REFERENCES t_users(c_user_id),
    c_amount DECIMAL(10, 2) NOT NULL,
    c_category_id INT NOT NULL REFERENCES t_categories(c_category_id),
    c_description TEXT,
    c_date_created TIMESTAMP NOT NULL DEFAULT NOW(),
    c_date_updated TIMESTAMP NOT NULL DEFAULT NOW()
);

CREATE TABLE t_categories (
    c_category_id SERIAL PRIMARY KEY,
    c_category_name VARCHAR(255) NOT NULL,
    c_user_id INT REFERENCES t_users(c_user_id) ON DELETE CASCADE,  -- nullable for global categories
    c_type_id INT NOT NULL REFERENCES t_types(c_type_id),
    c_icon TEXT,
    c_date_created TIMESTAMP NOT NULL DEFAULT NOW(),
    c_date_updated TIMESTAMP NOT NULL DEFAULT NOW(),
    c_is_active BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE t_transaction_types (
    c_type_id SERIAL PRIMARY KEY,
    c_type_name VARCHAR(255) NOT NULL
);

-- Triggers

CREATE OR REPLACE FUNCTION update_timestamp()
RETURNS TRIGGER AS $$
BEGIN
    NEW.c_date_updated = NOW();
    RETURN NEW;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER trigger_users_update_timestamp
BEFORE UPDATE ON t_users
FOR EACH ROW
EXECUTE FUNCTION update_timestamp();

CREATE TRIGGER trigger_categories_update_timestamp
BEFORE UPDATE ON t_categories
FOR EACH ROW
EXECUTE FUNCTION update_timestamp();