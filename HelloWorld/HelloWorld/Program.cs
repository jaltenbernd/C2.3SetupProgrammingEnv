using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            var checking = new CheckingAccount("JohnDoe", 15);

            Console.WriteLine($"A new checking account for {checking.Name} is now open with a balance of {checking.Balance:C}");

            Console.WriteLine("Would you like to withdraw an amount? (Y/N)");

            var isWithdrawal = Console.ReadLine();

            if (isWithdrawal.ToUpper() == "Y")
            {
                Console.WriteLine("How much?");

                var withdrawAmount = Console.ReadLine();

                checking.Withdraw(Convert.ToDouble(withdrawAmount));

                Console.WriteLine($"Your new balance: {checking.Balance:C}");
            }
            else
            {
                Console.WriteLine("Thank you.");
            }

            Console.ReadLine();

        }
    }
}
