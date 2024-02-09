--create database ATM2

CREATE TABLE Bank (
  BankID int,
  BName varchar(255),
  BTelNo int,
  Blocation varchar(255)
);

CREATE TABLE Feedback (
  FeedbackID int,
  BankID int,
  CusID int,
  FDescription varchar(255)
);

CREATE TABLE ATM (
  ATMID int,
  BankID int,
  AtmLocation varchar(255)
);

CREATE TABLE Customers (
  CusID int,
  TRID int,
  FeedbackID int,
  BankID int,
  Age int,
  CtelNo int,
  Caddress varchar(255),
  CName varchar(255),
  AccNum int
);

CREATE TABLE CustomersATM (
  ATMID int,
  CusID int
);

CREATE TABLE Transactions (
  TRID int,
  BankID int,
  TRAmount int,
  TrTime datetime,
  TrDate date,
  CusID int
);

CREATE TABLE Accounts (
  AccID int,
  CusID int,
  AccType varchar(255)
);

CREATE TABLE Loans (
  LoanID int,
  BankID int,
  CurrentID int
);

CREATE TABLE Withdraw (
  TRID int,
  WithdrawID int
);

CREATE TABLE Deposit (
  TRID int,
  DepositID int
);

CREATE TABLE SavingAccounts (
  AccID int,
  SavingID int
);

ALTER TABLE Bank
ADD PRIMARY KEY (BankID);