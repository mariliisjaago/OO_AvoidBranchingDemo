using DemoLibrary;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            Action customAction = CustomActionImplementation1;
            var myAccount = new Account(customAction);

            Console.WriteLine($"Created account, nalance: { myAccount.Balance }");

            myAccount.Deposit(3.0m);

            Console.WriteLine($"Deposited, balance: { myAccount.Balance }");

            myAccount.Freeze();

            myAccount.Deposit(4.0m);

            Console.WriteLine($"Unfroze, deposited, balance: { myAccount.Balance }");

            myAccount.VerifyOwner();

            myAccount.Withdraw(2.0m);

            Console.WriteLine($"Unfroze, withdrew, balance: { myAccount.Balance }");

            myAccount.CloseAccount();
        }

        private static void CustomActionImplementation1()
        {
            Console.WriteLine("I got unfreezed");
        }
    }
}
