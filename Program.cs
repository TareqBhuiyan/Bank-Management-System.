using System;

namespace ConsoleAppBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank b = new Bank(100);
            Account acc = new Account();
            Account s = new Savings();
            Account c = new Current();
            Account l = new Loan();

            

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("-----COMMAND LIST-----\n");
                Console.WriteLine("open ----- for ------- opening an account");
                Console.WriteLine("account ----- for ------- performing a transaction");
                Console.WriteLine("quit ----- for ------- exit\n\n");
                Console.Write("Please type your command: ");

                String bank = Console.ReadLine();
                
                // Bank b2 = new Bank(100);
                //Account acc = new Account();
                //Savings s = new Savings();
                //Current c = new Current();

                switch (bank)
                {
                    case "Open":

                        Console.WriteLine("\n\nOpen an account:\n");
                        Console.WriteLine("-----COMMAND LIST-----");
                        Console.WriteLine("savings ----- for ------- opening a savings account");
                        Console.WriteLine("current ----- for ------- opening a checking account");
                        Console.WriteLine("loan ----- for ------- opening a loan account");
                        Console.WriteLine("quit ----- for ------- exit\n\n");
                        Console.Write("Please type your command: ");

                        string open = Console.ReadLine();
                        //Bank b = new Bank(100);
                        //Account acc = new Account();
                        //Savings s = new Savings();

                        switch (open)
                        {
                            case "savings":

                                Console.WriteLine("Write your name: ");
                                s.AccountName = Console.ReadLine();
                                Console.WriteLine("\nWrite your date of birth: ");
                                s.DOB = Console.ReadLine();
                                Console.WriteLine("\nWrite your address:  ");
                                s.AccountAddress = Console.ReadLine();
                                Console.WriteLine("\nWrite your starting amount: ");
                                s.CurrentBalance = Convert.ToInt32(Console.ReadLine());
                                s.ID();
                                b.CreateAccount(s);


                                Console.WriteLine("Your account is successfully created.\nYour account number: " + s.Account_Number);
                                //acc.AccountDetails(Console.ReadLine());
                                break;
                            case "current":
                                Console.WriteLine("Write your name: ");
                                c.AccountName = Console.ReadLine();
                                Console.WriteLine("\nWrite your date of birth: ");
                                c.DOB = Console.ReadLine();
                                Console.WriteLine("\nWrite your address: ");
                                c.AccountAddress = Console.ReadLine();
                                Console.WriteLine("\nWrite your starting amount: ");
                                c.CurrentBalance = Convert.ToInt32(Console.ReadLine());
                                c.ID();
                                b.CreateAccount(c);
                                Console.WriteLine("Your account is successfully created.\nYour account number: " + c.Account_Number);
                                break;
                            case "loan":
                                Console.WriteLine("Write your name: ");
                                c.AccountName = Console.ReadLine();
                                Console.WriteLine("\nWrite your date of birth: ");
                                c.DOB = Console.ReadLine();
                                Console.WriteLine("\nWrite your address: ");
                                c.AccountAddress = Console.ReadLine();
                                Console.WriteLine("\nWrite your starting of loan amount: ");
                                c.CurrentBalance = Convert.ToInt32(Console.ReadLine());
                                c.ID();
                                b.CreateAccount(c);
                                Console.WriteLine("Your loan account is successfully created.\nYour account number: " + c.Account_Number);
                                break;

                            case "quit":
                                break;
                            default:
                                Console.WriteLine("ERROR: Please write your command as it shown!");
                                break;
                        }

                        break;

                    case "account":
                        Console.WriteLine("Perform transactions on an account:\n");
                        Console.WriteLine("-----COMMAND LIST-----");
                        Console.WriteLine("deposit------for------making a deposit");
                        Console.WriteLine("withdraw ----- for ------- making a withdraw");
                        Console.WriteLine("transfer ----- for ------- making a transfer");
                        Console.WriteLine("change ----- for ------- changing name");
                        Console.WriteLine("show ----- for ------- showing the number of transactions");
                        Console.WriteLine("quit ----- for ------- exit\n\n");
                        Console.Write("Please type your command: ");

                        string cmd = Console.ReadLine();

                        switch (cmd)
                        {
                            case "deposit":
                                string AccountNumber;
                                Console.WriteLine("Type your Account no: ");
                                AccountNumber = Convert.ToString(Console.ReadLine());
                                if (AccountNumber == s.Account_Number)
                                {
                                    s.Deposit(AccountNumber);
                                }
                                else if (AccountNumber == c.Account_Number)
                                {
                                    c.Deposit(AccountNumber);
                                }
                                break;
                            case "withdraw":
                                string AccountNumber1;
                                Console.WriteLine("Type your Account no: ");
                                AccountNumber1 = Convert.ToString(Console.ReadLine());
                                if (AccountNumber1 == s.Account_Number)
                                {
                                    s.Withdraw(AccountNumber1);
                                }
                                else if (AccountNumber1 == c.Account_Number)
                                {
                                    c.Withdraw(AccountNumber1);
                                }
                                break;
                            case "transfer":
                                string AccountNumber2;
                                Console.WriteLine("Type your Account no: ");
                                AccountNumber2 = Convert.ToString(Console.ReadLine());
                                if (AccountNumber2 == s.Account_Number)
                                {
                                    s.Transfer(AccountNumber2);
                                }
                                else if (AccountNumber2 == c.Account_Number)
                                {
                                    c.Transfer(AccountNumber2);
                                }
                                break;
                            case "change":
                                string AccountNumber3;
                                Console.WriteLine("Type your Account no: ");
                                AccountNumber3 = Convert.ToString(Console.ReadLine());
                                if (AccountNumber3 == s.Account_Number)
                                {
                                    s.ChangeName(AccountNumber3);
                                }
                                else if (AccountNumber3 == c.Account_Number)
                                {
                                    //c.Deposit(AccountNumber3);
                                }
                                break;
                            case "show":
                                string AccountNumber4;
                                Console.WriteLine("Type your Account no: ");
                                AccountNumber4 = Convert.ToString(Console.ReadLine());
                                if (AccountNumber4 == s.Account_Number)
                                {
                                    Console.WriteLine("Till the number of transactions: " + s.TransactionNumber());
                                }
                                else if (AccountNumber4 == c.Account_Number)
                                {
                                    Console.WriteLine("Till the number of transactions: " + c.TransactionNumber());
                                }
                                break;
                            case "quit":
                                break;
                            default:
                                Console.WriteLine("ERROR: Please write your command as it shown!");
                                break;
                        }
                        break;
                }

                if (bank == "quit")
                {
                    break;
                }
            }





        }
    }
}
