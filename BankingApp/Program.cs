using System;

namespace BankingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("     Banking Application");
            Console.WriteLine("-----------------------------");

            Account userAccount = new Account(100);

            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nMenu:");
                Console.Write("\nSelect an option(1 or 2 or 3 or 4 ): ");

                Console.WriteLine("\n1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");


                switch (Console.ReadLine())
                {
                    case "1":
                        userAccount.DisplayBalance();
                        break;

                    case "2":
                        Console.Write("Enter deposit amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                        {
                            userAccount.Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input...Input a number");
                        }
                        break;

                    case "3":
                        Console.Write("Enter withdrawal amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
                        {
                            userAccount.Withdraw(withdrawalAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input...Input a number");
                        }
                        break;

                    case "4":
                        exit = true;
                        Console.WriteLine("Thank you for using the Banking Application!");
                        Console.WriteLine("Bye!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
            Console.ReadKey();
            Console.Beep();
        }
    }
}
