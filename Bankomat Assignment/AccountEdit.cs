using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat_Assignment
{
    internal class AccountEdit
    {
        //method for creating all accounts at the start
        public static BankAccount[] CreateAllAccounts(string[] accountNames)
        {
            //create an array to hold all of the objects
            BankAccount[] accountNr = new BankAccount[accountNames.Length];

            //create a random amount of initial money
            Random randomMoney = new Random();

            //go through the entire list and create objects for each installment of the array + random money
            for (int i = 0; i < accountNames.Length; i++)
            {
                accountNr[i] = new BankAccount(accountNames[i]);
                accountNr[i].SetMoney(randomMoney.Next(100, 10001));
            }
            return accountNr;
        }
        //method for try-catching int-inputs
        public static int NumberInputCatch()
        {
            while (true)
            {
                Console.CursorVisible = true;
                try
                {
                    int x = Convert.ToInt32(Console.ReadLine());

                    if (x < 0)
                    {
                        Console.WriteLine("You can't use negative numbers");
                    }
                    else
                    {
                        return x;
                    }
                }
                catch
                {
                    Console.CursorVisible = false;
                    Console.WriteLine("Please only input numbers.");
                }
            }
        }
        //method for editing the money on the accounts
        public static void MoneyEdits(int addRemove, string question, BankAccount[] accountNr, int whichAccount)
        {
            Console.Clear();
            Console.WriteLine($"How much money do you want to {question}?");

            int moneyEdit = NumberInputCatch();

            //turning a "normal number" into either positive or negative (add/remove)
            moneyEdit = (moneyEdit * addRemove);

            if (moneyEdit + accountNr[whichAccount].AccountMoney < 0)
            {
                Console.CursorVisible = false;
                Console.WriteLine("You don't have enough money for that.");
                Console.ReadLine();
                return;
            }

            //after checking to make sure that nothing goes wrong -> use method for changing account-money
            accountNr[whichAccount].SetMoney(moneyEdit);
        }
    }
}