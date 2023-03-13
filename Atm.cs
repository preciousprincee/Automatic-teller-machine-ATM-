using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static string name;
        static int accountNo;
        static int amount = 0;
        static int tot = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("welcome");

            Console.WriteLine("what is your name");
            name = Console.ReadLine();

            Console.WriteLine("What is your accountNum");
            accountNo = Convert.ToInt32(Console.ReadLine());

            int chioce;

            while (true)
            {
                Console.WriteLine("\n--------------------------------");
                Console.WriteLine("-------WELCOME");
                Console.WriteLine("Enter you chioce \n");
                Console.WriteLine("enter to 1 withdraw, enter 2 to deposit, enter 3 to show balance");
                chioce = Convert.ToInt32(Console.ReadLine());

                switch (chioce)
                {
                    case 1:
                        Withdrawl(name, accountNo, tot);
                        break;
                    case 2:
                        deposit();
                        break;
                    case 3:
                        showBalance();
                        break;
                }
            }
        }

        static void showData(string name, int accountNo)
        {
            Console.WriteLine("NAME:" + name);
            Console.WriteLine("account Number:" + accountNo);

        }

        static void Withdrawl(string name, int accountNo, int tot)
        {
            int amount_to_withdraw, aval_balance;
            Console.WriteLine("enter amount to withdraw\n");
            amount_to_withdraw = Convert.ToInt32(Console.ReadLine());
            aval_balance = tot - amount_to_withdraw;
            Console.WriteLine("available balance is" + aval_balance);


        }

        static void showBalance()
        {
            tot = tot + amount;
            Console.WriteLine("\n your balance is: " + tot);
        }

        static void deposit()
        {
            Console.WriteLine("enter amount to be deposited");
            amount = Convert.ToInt32(Console.ReadLine());

        }


    }
}
