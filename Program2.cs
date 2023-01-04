using System;

namespace MyFirstProject
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.Write("What is your name?: ");
        String strName = Console.ReadLine();
        String contact = Console.ReadLine();
        Console.WriteLine("Welcome to the C# Tutorial! {0},{1}", strName,contact);

        }
    }
}
