using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankdetails
{
    internal class Program
    {
        static void Main(string[] args)
        // Create an instance of the bankaccount class
        {
            bankaccount bankAccount = new bankaccount();

            Console.WriteLine("Select an account type:");
            Console.WriteLine("1. Savings Account");
            Console.WriteLine("2. Current Account");
            Console.WriteLine("3. Gold Loan Account");

            int choice = int.Parse(Console.ReadLine());//parse is used to convert string to an integer
            double Balance;

            switch (choice)
            {
                case 1:
                    Console.Write("Enter savings account balance: ");
                    Balance = double.Parse(Console.ReadLine());
                    double savingsInterest = bankAccount.Calculatesavingsinterest(Balance);
                    Console.WriteLine($"Interest: {savingsInterest}");
                    break;

                case 2:
                    Console.Write("Enter current account balance: ");
                    Balance = double.Parse(Console.ReadLine());
                    double currentInterest = bankAccount.Calculatecurrentinterest(Balance);
                    Console.WriteLine($"Interest: {currentInterest}");
                    break;

                case 3:
                    Console.Write("Enter gold loan principal: ");
                    double Principal = double.Parse(Console.ReadLine());
                    double goldLoanInterest = bankAccount.Calculategoldinterest(Principal);
                    Console.WriteLine($"Interest: {goldLoanInterest}");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
