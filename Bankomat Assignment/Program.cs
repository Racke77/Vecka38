using System.ComponentModel.Design;
using Bankomat_Assignment;

namespace Bankomat_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Console.WriteLine("Welcome to The Bank");
            Console.ReadLine();

            //create all bank-accounts
            string[] allAccountNames = Menu.AllAccountNames();
            BankAccount[] accountNr = AccountEdit.CreateAllAccounts(allAccountNames);

            //while-loop to stop from escaping the menu
            while (true)
            {
                int menuSelected = Menu.MenuMakerActions();
                Console.Clear();

                switch (menuSelected)
                {
                    case 0:
                        //Display all accounts
                        for (int i = 0; i < accountNr.Length; i++)
                        {
                            Console.Write(accountNr[i].AccountNr + accountNr[i].AccountMoney.ToString().PadLeft(20) + " SEK");
                            Console.WriteLine();
                        }
                        Console.ReadLine();
                        break;
                    case 1:
                        //View account -> open a menu for account-names -> open the account
                        menuSelected = Menu.MenuSelection(allAccountNames);
                        Console.Clear();

                        Console.Write(accountNr[menuSelected].AccountNr);
                        Console.Write(accountNr[menuSelected].AccountMoney.ToString().PadLeft(20) + " SEK");
                        Console.ReadLine();
                        break;
                    case 2:
                        //Add to account -> open a menu for account-names (send Add)
                        menuSelected = Menu.MenuSelection(allAccountNames);
                        AccountEdit.MoneyEdits(1, "deposit", accountNr, menuSelected);
                        break;
                    case 3:
                        //Remove from account -> open a menu for account-names (send Remove)
                        menuSelected = Menu.MenuSelection(allAccountNames);
                        AccountEdit.MoneyEdits(-1, "withdraw", accountNr, menuSelected);
                        break;
                    case 4:
                        //Quit
                        Environment.Exit(1);
                        break;
                }
            }
        }
    }
}
