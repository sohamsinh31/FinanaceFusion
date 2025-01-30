INSERT INTO t_users (c_first_name, c_last_name, c_email, c_password) VALUES 
    ('John', 'Doe', '3o9i0@example.com', 'password123'),
    ('Jane', 'Doe', 'Tl3d2@example.com', 'password456'),
    ('Alice', 'Smith', 'hTm0W@example.com', 'password789'),
    ('Bob', 'Johnson', 'b2B0y@example.com', 'passwordabc'),
    ('Charlie', 'Brown', 'b2B0y@example.com', 'passwordxyz');

INSERT INTO t_types (c_type_name) VALUES 
    ('Income'),
    ('Expense');
INSERT INTO t_categories (c_category_name, c_user_id, c_type_id) VALUES 
    ('Salary', 1, 1),
    ('Rent', 2, 2),
    ('Scholarship', 3, 1),
    ('Entertainment', 4, 2),
    ('Transportation', 5, 2);
INSERT INTO t_transactions (c_user_id, c_amount, c_category_id) VALUES 
    (1, 100.00, 1),
    (2, 50.00, 2),
    (3, 75.00, 3),
    (4, 25.00, 4),
    (5, 125.00, 5);