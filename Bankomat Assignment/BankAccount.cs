using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat_Assignment
{
    public class BankAccount
    {
        public string AccountNr { get; }

        //no "set" because we want to be very careful with what is and isn't allowed to change the money
        private int moneyAccount;
        public int AccountMoney
        {
            get
            {
                return moneyAccount;
            }
        }
        public BankAccount(string accountName)
        {
            AccountNr = accountName;
        }

        //the method which changes the money-value on a given account
        public void SetMoney(int value)
        {
            moneyAccount += value;
        }
    }
}
