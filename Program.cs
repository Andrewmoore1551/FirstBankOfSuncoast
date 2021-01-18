﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using CsvHelper;

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

            // var transactions = new List<Transaction>(){
            //     new Transaction()
            //     {
            //         Account = "checking",
            //         Type = "deposit",
            //         Amount = 45,
            //         TimeStamp = DateTime.Now,
            //     },

            //   new Transaction()
            //   {
            //       Account = "savings",
            //       Type = "deposit",
            //       Amount = 60,
            //       TimeStamp = DateTime.Now,
            //   },
            //   new Transaction()
            //   {
            //       Account = "checking",
            //       Type = "withdraw",
            //       Amount = 10,
            //       TimeStamp = DateTime.Now,
            //   },

            //     };
            Console.WriteLine("Welcome to First Bank Of Suncoast");

            var fileReader = new StreamReader("transactions.csv");
            var csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);
            var transactions = csvReader.GetRecords<Transaction>().ToList();
            fileReader.Close();

            var userHasNotChosenToQuit = false;

            while (userHasNotChosenToQuit == false)
            {

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
                    var fileWriter = new StreamWriter("transactions.csv");
                    var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);
                    csvWriter.WriteRecords(transactions);
                    fileWriter.Close();
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
                            var fileWriter = new StreamWriter("transactions.csv");
                            var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);
                            csvWriter.WriteRecords(transactions);
                            fileWriter.Close();

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
                            var fileWriter = new StreamWriter("transactions.csv");
                            var csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture);
                            csvWriter.WriteRecords(transactions);
                            fileWriter.Close();

                        }

                    }

                }
                if (choice == "history")
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
