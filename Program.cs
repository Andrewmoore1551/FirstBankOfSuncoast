using System;
using System.Collections.Generic;
using System.Linq;

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

            var transactions = new List<Transaction>(){
                new Transaction()
                {
                    Account = "checking",
                    Type = "Deposit",
                    Amount = 45,
                    TimeStamp = DateTime.Now,
                },

              new Transaction()
              {
                  Account = "checking",
                  Type = "Deposit",
                  Amount = 60,
                  TimeStamp = DateTime.Now,
              },
              new Transaction()
              {
                  Account = "checking",
                  Type = "Deposit",
                  Amount = 60,
                  TimeStamp = DateTime.Now,
              },

                };

            // Welcome to the app 
            Console.WriteLine("Welcome to First Bank Of Suncoast");
            // App Should load past transactions from a file when it first starts(Add later fileReader)

            var userHasNotChosenToQuit = false;
            // While the User hasn’t chosen to QUIT: (Bool is false)

            while (userHasNotChosenToQuit == false)
            {

                // Add a List<Transactions>
                // Display the Menu Options:
                Console.WriteLine("Deposit");
                Console.WriteLine("Withdraw");
                Console.WriteLine("Balance");
                Console.WriteLine("History");
                Console.WriteLine("Quit");
                Console.WriteLine("What would you like to do?");

                var choice = Console.ReadLine();
                string v = choice.ToLower().Trim();
                choice = v;


                if (choice == "deposit")
                {
                    Console.WriteLine("Do you want to deposit into Savings or Checking?");
                    var newAccount = Console.ReadLine();
                    Console.WriteLine("How much would you like to deposit");
                    var newAmount = int.Parse(Console.ReadLine());
                    var newtransaction = new Transaction()
                    {
                        Account = newAccount,
                        Amount = newAmount,
                        Type = "deposit",
                        TimeStamp = DateTime.Now,
                    };
                    transactions.Add(newtransaction);
                    //Write all the transactions to the file (the four lines of code for the fileWriter)
                }

                if (choice == "withdraw")
                {
                    Console.WriteLine("Do you want to withdraw from Savings or Checking?");
                    var newAccount = Console.ReadLine();
                    if (newAccount == "savings")
                    {
                        var findSavings = transactions.Where(money => money.Account == "savings");
                        var findDeposit = findSavings.Where(money => money.Type == "deposit").Sum(money => money.Amount);
                        var findWithdraw = findSavings.Where(money => money.Type == "withdraw").Sum(money => money.Amount);
                        var subtract = findDeposit - findWithdraw;
                        Console.WriteLine("How much would you like to withdraw from savings");
                        var withdrawAmount = int.Parse(Console.ReadLine());
                        if (subtract < withdrawAmount)
                        {
                            Console.WriteLine("Insufficient funds");
                        }
                        if (subtract > withdrawAmount)
                        {
                            var newtransaction = new Transaction()
                            {
                                Account = "savings",
                                Amount = withdrawAmount,
                                Type = "withdraw",
                                TimeStamp = DateTime.Now,
                            };
                            transactions.Add(newtransaction);
                            //Write all the transactions to the file (the four lines of code for the fileWriter)
                        }
                    }
                    if (newAccount == "checking")
                    {
                        var findChecking = transactions.Where(money => money.Account == "checking");
                        var findDeposit = findChecking.Where(money => money.Type == "deposit").Sum(money => money.Amount);
                        var findWithdraw = findChecking.Where(money => money.Type == "withdraw").Sum(money => money.Amount);
                        var subtract = findDeposit - findWithdraw;
                        Console.WriteLine("How much would you like to withdraw from checking");
                        var withdrawAmount = int.Parse(Console.ReadLine());
                        if (subtract < withdrawAmount)
                        {
                            Console.WriteLine("Insufficient funds");
                        }
                        if (subtract > withdrawAmount)
                        {
                            var newtransaction = new Transaction()
                            {
                                Account = "checking",
                                Amount = withdrawAmount,
                                Type = "withdraw",
                                TimeStamp = DateTime.Now,
                            };
                            transactions.Add(newtransaction);
                            //Write all the transactions to the file (the four lines of code for the fileWriter)
                        }

                    }

                }
                if (choice == "transaction history")
                {
                    Console.WriteLine("Would you like Savings or Checking");
                    var history = Console.ReadLine();
                    if (history == "savings")
                    {
                        var findSavings = transactions.Where(money => money.Account == "savings");
                        foreach (var save in findSavings)
                        {
                            Console.WriteLine($"Your Transaction History: Your {save.Account} was {save.Type} for the amount of {save.Amount}. ");
                        }
                    }
                    if (history == "checking")
                    {
                        var findChecking = transactions.Where(money => money.Account == "checking");
                        foreach (var check in findChecking)
                        {
                            Console.WriteLine($"Your Transaction History: Your {check.Account} was {check.Type} for the amount of {check.Amount}. ");
                        }
                    }
                }

                if (choice == "balance")
                {
                    Console.WriteLine("Would you like Savings or Checking?");
                    var total = Console.ReadLine();

                    if (total == "savings")
                    {
                        var findSavings = transactions.Where(money => money.Account == "savings");
                        var findDeposit = findSavings.Where(money => money.Type == "deposit").Sum(money => money.Amount);
                        var findWithdraw = findSavings.Where(money => money.Type == "withdraw").Sum(money => money.Amount);
                        var subtract = findDeposit - findWithdraw;
                        Console.WriteLine($"Your balance in savings is {subtract}");
                    }
                    if (total == "checking")
                    {
                        var findChecking = transactions.Where(money => money.Account == "checking");
                        var findDeposit = findChecking.Where(money => money.Type == "deposit").Sum(money => money.Amount);
                        var findWithdraw = findChecking.Where(money => money.Type == "withdraw").Sum(money => money.Amount);
                        var subtract = findDeposit - findWithdraw;
                        Console.WriteLine($"Your balance in checking is {subtract}");
                    }


                }
                if (choice == "quit")
                {
                    userHasNotChosenToQuit = true;
                }

            }
            Console.WriteLine("Thank you for visiting First Bank Of Suncoast");




        }
    }
}
