-- #region Transaction Types
INSERT INTO t_types (c_type_name) VALUES 
('Income'),
('Expense'),
('Investment'),
('Savings');
-- #endregion

-- #region Users
-- INSERT INTO t_users (c_first_name, c_last_name, c_email, c_password) VALUES 
-- ('John', 'Doe', 'john.doe@example.com', 'hashed_password_1'),
-- ('Alice', 'Smith', 'alice.smith@example.com', 'hashed_password_2');
-- #endregion

-- #region Categories
INSERT INTO t_categories (c_category_name, c_type_id) VALUES 
-- Income Categories
('Salary', 1),
('Freelance', 1),
('Bonus', 1),
('Gift', 1),

-- Expense Categories
('Food', 2),
('Clothing', 2),
('Travel', 2),
('Rent', 2),

-- Investment Categories
('Stocks', 3),
('Crypto', 3),
('Real Estate', 3),

-- Savings Categories
('Emergency Fund', 4),
('Retirement Fund', 4);
-- #endregion

-- #region Transactions
-- INSERT INTO t_transactions (c_user_id, c_amount, c_category_id, c_description) VALUES 
-- Income Transactions
-- (1, 5000.00, 1, 'Monthly salary for June'),
-- (1, 1200.00, 2, 'Freelance project payment'),
-- (2, 800.00, 3, 'Performance bonus from company'),
-- (2, 100.00, 4, 'Gift from a friend'),

-- Expense Transactions
-- (1, -50.00, 5, 'Lunch at a restaurant'),
-- (1, -80.00, 6, 'Bought a new T-shirt'),
-- (2, -200.00, 7, 'Flight ticket for vacation'),
-- (2, -1000.00, 8, 'Monthly house rent'),

-- Investment Transactions
-- (1, -300.00, 9, 'Bought Tesla Stocks'),
-- (1, -500.00, 10, 'Invested in Bitcoin'),
-- (2, -1000.00, 11, 'Purchased rental property'),

-- Savings Transactions
-- (1, -500.00, 12, 'Added money to emergency fund'),
-- (2, -700.00, 13, 'Contributed to retirement savings');
-- #endregion