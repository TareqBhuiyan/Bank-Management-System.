using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppBank
{
  
      class Account
        {
            private string Name;
            private string DateOfBirth;
            private string Address;
            private int Balance;
            private string AccountNumber;
            public static int accNumber = 10001;
            public int transaction = 0;

            public string Account_Number
            {
                set { this.AccountNumber = value; }
                get { return this.AccountNumber; }

            }
            public string AccountName
            {
                set { this.Name = value; }
                get { return this.Name; }
            }

            public string DOB
            {
                set { this.DateOfBirth = value; }
                get { return this.DateOfBirth; }
            }

            public string AccountAddress
            {
                set { this.Address = value; }
                get { return this.Address; }
            }



            public int CurrentBalance
            {
                set { this.Balance = value; }
                get { return this.Balance; }
            }

            public int ID()
            {
                this.Account_Number = accNumber.ToString();
                accNumber++;
                return accNumber;
            }



            public int TransactionNumber()
            {
                transaction++;
                return transaction;
            }


            public virtual void Deposit(string ANumber)
            {
                ANumber = this.Account_Number;

            }

            public virtual void Withdraw(string ANumber)
            {
                ANumber = this.Account_Number;

            }


            public virtual void Transfer(string ANumber)
            {
                ANumber = this.Account_Number;

            }


            public virtual void ChangeName(string ANumber)
            {
                ANumber = this.Account_Number;

            }

            public void TransferAmount(string ANumber, int amount)
            {
                ANumber = this.Account_Number;
                this.CurrentBalance += amount;
            }
        }
    
}
