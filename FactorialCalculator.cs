using System;
class Program
{
    static long Factorial(int n)
    {
        long result = 1;
        for (int i = 1; i <= n; i++)
        { result *= i; } // multiply each number
        return result;
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        long fact = Factorial(n); // call method
        Console.WriteLine("Factorial of " + n + " = " + fact);
    }
}