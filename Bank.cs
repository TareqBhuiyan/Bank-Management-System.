using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBank
{
    class Bank 
    {
        private readonly Account[] accounts;

        public Bank(int size)
        {
            this.accounts = new Account[size];
        }

        public void CreateAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    break;
                }
            }
        }
    }
}
