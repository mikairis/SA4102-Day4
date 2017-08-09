using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Start:
            int count = 0;

            string password = "123456";

            Console.WriteLine("Welcome to the bank of ISS");
            Console.WriteLine("Enter your PIN: ");
            string userInput = Console.ReadLine();

            while (count != 2)
            {  
                if (userInput == password)
                {
                    Console.WriteLine("PIN accepted. You can access your account now.");
                    Console.ReadKey();
                    Console.WriteLine();
                    goto Start;
                }
                else
                {
                    Console.WriteLine("Incorrect PIN. Please try again.");
                    Console.WriteLine("Enter your PIN: ");
                    userInput = Console.ReadLine();
                    count++;
                }
            }
            Console.WriteLine("Too many wrong PIN tries. Your account is now locked!");
            Console.ReadKey();
            Console.WriteLine();
            goto Start;*/

            int[] a = new int[10] { 34, 72, 24, 16, 95, 43, 34, 67, 22, 51 };

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int larger = a[i];
                        a[i] = a[j];
                        a[j] = larger;
                    }
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.ReadKey();

        }
    }
}