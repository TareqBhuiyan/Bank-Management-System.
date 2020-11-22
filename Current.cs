using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBank
{
    class Current : Account
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
            base.CurrentBalance = base.CurrentBalance - amount;
            Console.WriteLine("Amount Withdrawed!\nCurrent Balance: " + base.CurrentBalance);
            base.TransactionNumber();

        }

        public override void Transfer(string ANUmber)
        {
            ANUmber = base.Account_Number;

            int amount;
            Console.WriteLine("Receive or, Send: ");
            string wish = Console.ReadLine();
            switch (wish)
            {
                case "Send":
                    Console.WriteLine("Type receiver's account no: ");
                    ANUmber = Console.ReadLine();
                    Console.WriteLine("Type amount: ");
                    amount = Convert.ToInt32(Console.ReadLine());

                    base.CurrentBalance = base.CurrentBalance - amount;
                    base.TransferAmount(ANUmber, amount);
                    Console.WriteLine("Amount sent!\nCurrent Balance: " + base.CurrentBalance);
                    base.TransactionNumber();
                    break;
                case "Receive":
                    Console.WriteLine("Type sender's account no: ");
                    ANUmber = Console.ReadLine();
                    Console.WriteLine("Type amount: ");
                    amount = Convert.ToInt32(Console.ReadLine());

                    base.CurrentBalance = base.CurrentBalance + amount;
                    base.TransferAmount(ANUmber, amount);
                    Console.WriteLine("Amount received!\nCurrent Balance: " + base.CurrentBalance);
                    base.TransactionNumber();
                    break;
            }


        }
       



        public override void ChangeName(string ANumber)
        {
            ANumber = base.Account_Number;
            string NewName;
            Console.WriteLine("Type your new name: ");
            NewName = Console.ReadLine();
            base.AccountName = NewName;
            Console.WriteLine("Your changed name: " + base.AccountName);
        }
    }
}
