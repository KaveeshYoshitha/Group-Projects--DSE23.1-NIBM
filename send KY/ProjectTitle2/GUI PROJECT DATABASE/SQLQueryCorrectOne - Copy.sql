--create database ATMLast

CREATE TABLE Bank (
    BankID INT PRIMARY KEY,
    BName VARCHAR(255),
    BTel_no VARCHAR(20),
    BLocation VARCHAR(255)
);

CREATE TABLE Feedback (
    FeedbackID INT PRIMARY KEY,
    BankID INT,
    CusID INT,
    Description VARCHAR(255),
    FOREIGN KEY (BankID) REFERENCES Bank(BankID),
    --FOREIGN KEY (CusID) REFERENCES Customers(CusID)
);

ALTER TABLE Feedback
ADD FOREIGN KEY (CusID) REFERENCES Customers(CusID);



CREATE TABLE ATM (
    ATMID INT PRIMARY KEY,
    BankID INT,
    Location VARCHAR(255),
    FOREIGN KEY (BankID) REFERENCES Bank(BankID)
);

CREATE TABLE Customers (
    CusID INT PRIMARY KEY,
    TrID INT,
    FeedbackID INT,
    BankID INT,
    Age INT,
    CTel_no VARCHAR(20),
    CAddress VARCHAR(255),
    Name VARCHAR(255),
    AccNum INT,
   -- FOREIGN KEY (TrID) REFERENCES Transactions(TrID),
    FOREIGN KEY (FeedbackID) REFERENCES Feedback(FeedbackID),
    FOREIGN KEY (BankID) REFERENCES Bank(BankID)
);

ALTER TABLE Customers
ADD FOREIGN KEY (TrID) REFERENCES Transactions(TrID);


CREATE TABLE Customers_ATM (
    ATMID INT,
    CusID INT,
    PRIMARY KEY (ATMID, CusID),
    FOREIGN KEY (ATMID) REFERENCES ATM(ATMID),
    FOREIGN KEY (CusID) REFERENCES Customers(CusID)
);

CREATE TABLE Transactions (
    TrID INT PRIMARY KEY,
    BankID INT,
    TR_Amount DECIMAL(10, 2),
    Time TIME,
    Date DATE,
    CusID INT,
    FOREIGN KEY (BankID) REFERENCES Bank(BankID),
    FOREIGN KEY (CusID) REFERENCES Customers(CusID)
);

CREATE TABLE Accounts (
    AccID INT PRIMARY KEY,
    CusID INT,
    Acc_Type VARCHAR(50),
    FOREIGN KEY (CusID) REFERENCES Customers(CusID)
);

CREATE TABLE Loans (
    LoanID INT PRIMARY KEY,
    BankID INT,
    CurrentID INT,
    FOREIGN KEY (BankID) REFERENCES Bank(BankID),
   -- FOREIGN KEY (CurrentID) REFERENCES Current_Accounts(CurrentID)
);

ALTER TABLE Loans
ADD FOREIGN KEY (CurrentID) REFERENCES Current_Accounts(CurrentID);


CREATE TABLE Withdraw (
    TrID INT,
    WithdrawID INT PRIMARY KEY,
    FOREIGN KEY (TrID) REFERENCES Transactions(TrID)
);

CREATE TABLE Deposit (
    TrID INT,
    DepositID INT PRIMARY KEY,
    FOREIGN KEY (TrID) REFERENCES Transactions(TrID)
);

CREATE TABLE Saving_Accounts (
    AccID INT,
    SavingID INT PRIMARY KEY,
    FOREIGN KEY (AccID) REFERENCES Accounts(AccID)
);

CREATE TABLE Current_Accounts (
    AccID INT,
    CurrentID INT PRIMARY KEY,
    FOREIGN KEY (AccID) REFERENCES Accounts(AccID)
);



