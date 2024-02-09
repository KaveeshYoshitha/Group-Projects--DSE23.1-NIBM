create database ATML01;

CREATE TABLE login_table (
    account_number INT PRIMARY KEY,
    pin_number INT
);

-- Create Account Manager Form Table
CREATE TABLE account_manager_table (
    account_number INT PRIMARY KEY,
    balance DECIMAL,
    transaction_type VARCHAR(20),
    FOREIGN KEY (account_number) REFERENCES login_table(account_number)
);

-- Create Check Balance Form Table
CREATE TABLE check_balance_table (
    account_number INT PRIMARY KEY,
    account_balance DECIMAL,
    FOREIGN KEY (account_number) REFERENCES account_manager_table(account_number)
);

-- Create Deposit Form Table
CREATE TABLE deposit_table (
    account_number INT PRIMARY KEY,
    deposit_amount DECIMAL,
    FOREIGN KEY (account_number) REFERENCES account_manager_table(account_number)
);

-- Create Withdraw Form Table
CREATE TABLE withdraw_table (
    account_number INT PRIMARY KEY,
    withdraw_amount DECIMAL,
    FOREIGN KEY (account_number) REFERENCES account_manager_table(account_number)
);

--Insert data to tabele

-- Insert data into login_table
INSERT INTO login_table (account_number, pin_number) VALUES
(1001, 1234),
(1002, 5678),
(1003, 9876);

-- Insert data into account_manager_table
INSERT INTO account_manager_table (account_number, balance, transaction_type) VALUES
(1001, 1000.00, 'deposit'),
(1002, 500.50, 'deposit'),
(1003, 150.25, 'deposit');

-- Insert data into check_balance_table
INSERT INTO check_balance_table (account_number, account_balance) VALUES
(1001, 1000.00),
(1002, 500.50),
(1003, 150.25);

-- Insert data into deposit_table
INSERT INTO deposit_table (account_number, deposit_amount) VALUES
(1001, 200.00),
(1002, 50.75),
(1003, 30.50);

-- Insert data into withdraw_table
INSERT INTO withdraw_table (account_number, withdraw_amount) VALUES
(1001, 50.00),
(1002, 20.25),
(1003, 10.00);




		select * from login_table;