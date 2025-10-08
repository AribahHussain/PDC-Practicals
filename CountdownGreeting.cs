using System;
using System.Threading;
class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("\nLoading...");
        for (int i = 5; i >= 0; i--)
        {
            Console.WriteLine(i);
            if (i == 5)
                Thread.Sleep(500); // 0.5 sec delay for first number
            else
                Thread.Sleep(1000); // 1 sec delay for others
        }
        Console.WriteLine($"\nWelcome {name}!");
    }
}