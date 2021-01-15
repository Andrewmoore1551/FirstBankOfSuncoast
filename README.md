# FirstBankOfSuncoast

PROBLEM
Create a banking app that allows us to make and track withdrawals and deposits in two accounts, checking and savings. Doing this through Transactions.
Keep track of balance history by looking at all of the transactions that have been done
The transaction will be saved in a file, using CSV format to record the data.

C R U D
Create: (Deposit/ Withdraw) (create) a new transaction.
Read: Transaction History
Update: Update Checking and Savings
Delete: Removing funds from the account (Withdraw)

EXAMPLES
If a user deposits 10 to their savings, then withdraws 8 from their savings, then deposits 25 to their checking, they have three transactions to consider. Compute the checking and saving balance, using the transaction list, when needed. In this case, their savings balance is 2 and their checking balance is 25.

I go to the bank and check my balances for both my Savings and Checking accounts.

I go to the bank and try to withdraw $30, but I only have $12 cause I’m broke. The bank doesn’t give me $30. They suck.

I request a list of my transactions from my Savings and Checking accounts.

My accounts can never go negative.

I go to the bank and deposit $10 into my checking account. Withdraw $5 from $20 in Savings and deposit $3 back into Checking. That is 3 transactions. I have $13 in checking left and $15 in savings left

Deposits 20 to checking, deposits 20 to savings, withdraws 12 from checking. 3 Transactions, 8 in checking 20 in savings

Deposits 30 to savings, Deposits 45 to checking, withdraws 40 from savings. The system does not allow me to overdraft. So 2 transactions, 30 in savings and 45 in checking

Data Structure
Create a “Welcome” and “Goodbye” message!

Create a Class called Transaction

Properties:  
Amount (int): (how much is in the transaction)
Kind of Transactions: Deposit, Withdraw
TimeStamp (DateTime) (Could add a time stamp on your transactions as well.)
Where the transaction is going: Checking, Savings,

Add a List<Transactions>

Multiple options for menu:

Menu Options:
-deposit transaction for savings
-deposit transaction for checking
-withdraw transaction for savings
-withdraw transaction for checking
-view balance of savings and checking
-transaction history
-quit

Instead of If Statements, you can use Switch Statements

Algorithm
Welcome to the app
Add a Class: Transaction
App Should load past transactions from a file when it first starts (fileReader)
While the User hasn’t chosen to QUIT: (Bool is false)

Display the Menu Options:
Deposit
Withdraw
Balance - int
Transaction History -
Quit
Ask the user what they would like to choose?

switch (choice)
{

case “Deposit”:
Ask the user if they would like to choose Savings or Checking?
Console writeLine
Console readLine of answer

    If (Savings)
    Ask how much they want to input into savings?

    If (Checking)
    Ask how much they want to input into Checking?
    Write all the transactions to the file (the four lines of code for the fileWriter)
    break;

case “Withdraw”:
Ask the user if they would like to choose Savings or Checking?
If (Savings)
Ask how much they want to withdraw from savings?
If there is enough money in account
Remove money from savings
Write all the transactions to the file (the four lines of code for the fileWriter)
If there isn’t enough money
Do not remove money from savings
If (Checking)
Ask how much they want to withdraw from checking?
If there is enough money in account
Remove money from savings
Write all the transactions to the file (the four lines of code for the fileWriter)
If there isn’t
Do not remove money from savings

If (Transaction History)
Ask the user if they would like to choose Savings or Checking?
If (Savings)
Print out the Transaction History for Savings
If (Checking)
Print out the Transaction History for Checking

If (Balance)
Ask the user if they would like to choose Savings or Checking?
If (Savings)
See the Balance of the Savings
If (Checking)
See the Balance of the Checking

If (Quit)
Bool is True

11. Say Goodbye
