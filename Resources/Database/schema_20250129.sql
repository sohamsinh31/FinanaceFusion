CREATE TABLE t_users (
    c_user_id SERIAL PRIMARY KEY,
    c_first_name VARCHAR(255) NOT NULL,
    c_last_name VARCHAR(255) NOT NULL,
    c_email VARCHAR(255) NOT NULL,
    c_password VARCHAR(50) NOT NULL,
    c_date_created TIMESTAMP NOT NULL DEFAULT NOW(),
    c_date_updated TIMESTAMP NOT NULL DEFAULT NOW(),
    c_is_active BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE t_transactions (
    c_transaction_id SERIAL PRIMARY KEY,
    c_user_id INT NOT NULL REFERENCES t_users(c_user_id),
    c_amount DECIMAL(10, 2) NOT NULL,
    c_category_id INT NOT NULL REFERENCES t_categories(c_category_id),
    c_date_created TIMESTAMP NOT NULL DEFAULT NOW(),
    c_date_updated TIMESTAMP NOT NULL DEFAULT NOW()
);

CREATE TABLE t_categories (
    c_category_id SERIAL PRIMARY KEY,
    c_category_name VARCHAR(255) NOT NULL,
    c_user_id INT NOT NULL REFERENCES t_users(c_user_id),
    c_type_id INT NOT NULL REFERENCES t_types(c_type_id),
    c_date_created TIMESTAMP NOT NULL DEFAULT NOW(),
    c_date_updated TIMESTAMP NOT NULL DEFAULT NOW(),
    c_is_active BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE t_types (
    c_type_id SERIAL PRIMARY KEY,
    c_type_name VARCHAR(255) NOT NULL
);