using System;

namespace FirstBankOfSuncoast
{
    class Transaction
    {
        public string Type { get; set; }
        public string Account { get; set; }
        public int Amount { get; set; }
        public DateTime TimeStamp { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {



            // Welcome to the app 
            Console.WriteLine("Welcome to First Bank Of Suncoast");
            // App Should load past transactions from a file when it first starts(Add later fileReader)

            var userHasNotChosenToQuit = false;
            while (userHasNotChosenToQuit == false)
            {



                // While the User hasn’t chosen to QUIT: (Bool is false)



                // Add a List<Transactions>
                // Var newtransaction = new Transaction()
                // {
                // 	Account = “Savings”,
                // 	Type = “Deposit”,
                // Amount = 45, 
                // TimeStamp = DateTime.Now,
                // };
                // 	transaction.Add(newtransaction);


                // Display the Menu Options:
                // 	Deposit
                // 	Withdraw
                // 	Balance - int
                // 	Transaction History -
                // 	Quit

                // 	Ask the user what they would like to choose?
                // Console.Write(“Ask the user what they would like to choose? “);
                // Var choice = Console.ReadLine();
                // switch (choice)
                // {
                // If (choice == “DEPOSIT”
                // case “Deposit”(Like Add in Dino) (if (userChoice==Deposit) ADD))
                // {
                // Ask the user "Do you want to deposit into Savings or Checking?"
                // Console.Write(“Do you want to deposit into Savings or Checking?” );
                //     Console readLine of answer as 'whereDepositIsGoing'= Account ( --var             newAccount=Answer (savings or checkings))
                // Var newAccount = Console.ReadLine();
                //     Ask $"How much they want to input into {answer}" 
                // Console.Write($"How much they want to input into {newAccount}? “}
                //     Console readline of answer and parse into int as 'amountOfDeposit' = Amount  (--var newAmount= answer (How much))
                // Var newAmount = int.Parse(Console.ReadLine());
                //     create a new Transaction object, filling in these properties
                //  var newtransaction= new Transaction()
                //       - Amount = amountOfDeposit ( newtransaction.Amount=newAmount)
                //       - KindOfTransaction = "Deposit" (  --var newType=deposit (deposit or withdraw)
                //       - TimeStamp - fill in with the current time = DateTime.Now
                //       - WhereGoing = whereDepositIsGoing = Account (newtransaction.Account=newAccount)
                //     Add that new transaction our `List`

                // transaction.Add(newtransaction)

                //     Write all the transactions to the file (the four lines of code for the fileWriter)
                //     Break; “”

                // case “Withdraw”:
                // 	Ask the user if they would like to choose Savings or Checking?
                // 	If (Savings)
                // 	Ask how much they want to withdraw from savings?
                // 	-Find savings
                // 		If there is enough money in account
                // 			Remove money from savings
                // Write all the transactions to the file (the four lines of code for the fileWriter)
                // 		If there isn’t enough money
                // 			Do not remove money from savings

                // 	If (Checking)
                // 	Ask how much they want to withdraw from checking?
                // 			If there is enough money in account
                // 			Remove money from savings
                // Write all the transactions to the file (the four lines of code for the fileWriter)
                // 		If there isn’t 
                // 			Do not remove money from savings

                // If (Transaction History)
                // 	Ask the user if they would like to choose Savings or Checking?
                // 	If (Savings)
                // 	Print out the Transaction History for Savings
                // 	If (Checking)
                // 	Print out the Transaction History for Checking

                // If (Balance)
                // 	Ask the user if they would like to choose Savings or Checking?
                // 	If (Savings) 
                // 	See the Balance of the Savings
                // 	If (Checking)
                // 	See the Balance of the Checking

                // If (Quit)
                // 	Bool is True
            }
            // 11. Say Goodbye



        }
    }
}
