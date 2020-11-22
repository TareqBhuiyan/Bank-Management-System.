using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleAppBank
{
    class Loan : Account
    {
        public override void Deposit(string ANumber)
        {
            ANumber = base.Account_Number;
            int amount;
            Console.WriteLine("Type amount: ");
            amount = Convert.ToInt32(Console.ReadLine());
            base.CurrentBalance += amount;
            Console.WriteLine("Amount Deposited!\nCurrent Balance: " + base.CurrentBalance);
            base.TransactionNumber();

        }

        public override void Withdraw(string ANumber)
        {
            ANumber = base.Account_Number;
            int amount;
            Console.WriteLine("Type amount: ");
            amount = Convert.ToInt32(Console.ReadLine());

            if (base.CurrentBalance - amount >= 500)
            {
                base.CurrentBalance = base.CurrentBalance - amount;
                Console.WriteLine("Amount Withdrawed!\nCurrent Balance: " + base.CurrentBalance);
                base.TransactionNumber();
            }
            else
            {
                Console.WriteLine("Isufficient withdrawal amount!");
            }
        }

       
    }
}
