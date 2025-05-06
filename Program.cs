using System;
using System.Reflection.Metadata;
using System.Security.Cryptography;

namespace bank
{
    public class Program
    {
        static void Pin()
        {
            int _min = 1000;
            int _max = 9999;
            Random _rdm = new Random();
            int pin = _rdm.Next(_min, _max);
            Console.WriteLine("Your Auto Generated PIN for ATM: " + pin);

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Bank!!\n\nREGISTER YOURSELF");

            Console.WriteLine("Enter Your Account Name: ");
            string user = Console.ReadLine();

            Console.WriteLine("Enter Your Account Number: ");
            long acno = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Date of Birth: ");
            string dob = Console.ReadLine();

            Console.WriteLine("Successful Registeration!! Congratulations!");
            Pin();
        }
    }
}