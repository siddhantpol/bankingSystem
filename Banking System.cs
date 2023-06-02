using banking_system;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace banking_system
{
    class accountInit
    {
        public static int AccNo = 0;
        protected internal string name;
        protected internal string AccType;
        public int principle;
        public static double intrestRate = 6.5;

        public accountInit(int AccNo, string name, string AccType, int principle)
        {
            this.name = name;
            this.AccType = AccType;
            this.principle = principle;
        }
        public accountInit() { }

        public accountInit(int AccNo)
        {
            AccNo += 1;
        }

        public void OpenAccount()
        {
            Console.WriteLine("\n\t\t\t\t\t\t\tYour Account Number is : " + AccNo);

            Console.WriteLine("\n\t\t\t\t\t\t\tEnter Your Name : ");
            name = Console.ReadLine();

            Console.WriteLine("\n\t\t\t\t\t\t\tAccount Type : \n\t\t\t\t\t\t\t1-Saving Account\n\t\t\t\t\t\t\t2-Current Account");
            int AccTy = Convert.ToInt32(Console.ReadLine());
            if (AccTy == 1) { AccType = "Saving"; }
            else { AccType = "Current"; }

        retry:
            Console.WriteLine("\n\t\t\t\t\t\t\tEnter Base Ammount to enter (Should be more than 10000): ");
            int baseAmount = Convert.ToInt32(Console.ReadLine());
            if (baseAmount < 10000) { Console.WriteLine("ERROR!!Base Amount less than minimum required amount"); goto retry; }
            else principle = baseAmount;
        }

        public void showDetails()
        {
            Console.WriteLine("\n\t\t\t\t\t\t\tAccount Number-  " + AccNo);
            Console.WriteLine("\n\t\t\t\t\t\t\tName of User-    " + name);
            Console.WriteLine("\n\t\t\t\t\t\t\tAccount Type-    " + AccType);
            Console.WriteLine("\n\t\t\t\t\t\t\tBalance-         " + principle);
        }
        public void Transaction()
        {   int choice,withdraw,diposit;
            Console.WriteLine("\n\t\t\t\t\t\t\tTRANSCTION\n1-WITHDRAW\t\t\t\t\t\t\t2-DIPOSIT");
            choice = Convert.ToInt32(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("\n\t\t\t\t\t\t\tEnter amount to Withdraw : ");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        principle -= withdraw;
                        Console.WriteLine("\n\t\t\t\t\t\t\tYour balance now is : " + principle);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("\n\t\t\t\t\t\t\tEnter amount to Diposit : ");
                        diposit = Convert.ToInt32(Console.ReadLine());
                        principle += diposit;
                        Console.WriteLine("\n\t\t\t\t\t\t\tYour balance now is : " + principle);
                    }
                    break;
                default:
                    Console.WriteLine("ERROR!! Wrong input");
                    break;
            }
            
        }
    }
}




internal class Class1
{
    static void Main(string[] args)
    {
        accountInit newacc1 = new accountInit();
        accountInit newacc2 = new accountInit();

    start:
        Console.Clear();

        Console.WriteLine("\t\t\t\t\t\tWELCOME TO BANKING SYSTEM\n\t\t\t\t\t\t\tMENU\n\t\t\t\t\t\t1.OPEN ACCOUNT\n\t\t\t\t\t\t" +
            "(mandatory to use another functions)\n\t\t\t\t\t\t2.TRANSACTION\n\t\t\t\t\t\t3.SHOW DETAILS\n\t\t\t\t\t\t4.CALCULATE INTREST" +
            "\n\t\t\t\t\t\t5.EXIT APPLICATION\n\t\t\t\t\t\tENTER YOUR CHOICE : ");
        int choice = Convert.ToInt32(Console.ReadLine());





        switch (choice)
        {
            case 1:
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t\t\tWELCOME TO BANKING SYSTEM\n\t\t\t\t\t\t\tOPEN ACCOUNT");
                    newacc1.OpenAccount();


                    //navigation
                    Console.WriteLine("\n\nGo back-1\nExit-2");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num == 1)
                        goto start;
                    else
                        Environment.Exit(num);
                }

                break;
            case 2:
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t\t\tWELCOME TO BANKING SYSTEM\n\t\t\t\t\t\t\tTRANSACTION");
                    newacc1.Transaction();


                    //navigation
                    Console.WriteLine("\n\nGo back-1\nExit-2");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num == 1)
                        goto start;
                    else
                        Environment.Exit(num);
                }
                break;
            case 3:
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t\t\tWELCOME TO BANKING SYSTEM\n\t\t\t\t\t\t\tSHOW DETAILS");
                    newacc1.showDetails();


                    //navigation
                    Console.WriteLine("\n\nGo back-1\nExit-2");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num == 1)
                        goto start;
                    else
                        Environment.Exit(num);

                }
                break;
            case 4:
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t\t\t\tWELCOME TO BANKING SYSTEM\n\t\t\t\t\t\t\tCALCULATE INTREST");


                    //navigation
                    Console.WriteLine("\n\nGo back-1\nExit-2");
                    int num = Convert.ToInt32(Console.ReadLine());
                    if (num == 1)
                        goto start;
                    else
                        Environment.Exit(num);
                }
                break;
            default:
                Console.Clear();
                break;
        }
    }
}

