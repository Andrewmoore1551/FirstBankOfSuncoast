﻿using System;
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
                        }

                    }
                }

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
