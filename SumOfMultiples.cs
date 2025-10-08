using System;
class Program
{
    static int SumMultiples(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0) // check if multiple of 3
            { sum += i; }
        }
        return sum;
    }
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int result = SumMultiples(n); // call method
        Console.WriteLine("Sum of multiples of 3 up to " + n + " = " + result);
    }
}