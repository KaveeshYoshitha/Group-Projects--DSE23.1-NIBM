create database ATMmyTry;

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
(1001, 10000.00, 'deposit'),
(1002, 50000.50, 'deposit'),
(1003, 15000.00, 'deposit');

-- Insert data into check_balance_table
INSERT INTO check_balance_table (account_number, account_balance) VALUES
(1001, 10000.00),
(1002, 50000.00),
(1003, 15000.00);

-- Insert data into deposit_table
INSERT INTO deposit_table (account_number, deposit_amount) VALUES
(1001, 10000.00),
(1002, 50000.00),
(1003, 15000.00);

-- Insert data into withdraw_table
INSERT INTO withdraw_table (account_number, withdraw_amount) VALUES
(1001, 10000.00),
(1002, 50000.25),
(1003, 15000.00);




		select * from check_balance_table;
		select * from withdraw_table;
				select * from deposit_table;