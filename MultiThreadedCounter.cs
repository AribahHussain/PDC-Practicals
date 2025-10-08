using System;
using System.Threading;
class Program
{
    static void Counter(string name)
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(name + " : " + i); // print counter value
            Thread.Sleep(500); // pause for half a second
        }
    }
    static void Main()
    {
        Thread t1 = new Thread(() => Counter("Counter 1"));
        Thread t2 = new Thread(() => Counter("Counter 2"));
        // Start threads
        t1.Start(); t2.Start();
        // Wait for both threads to finish
        t1.Join(); t2.Join();
        Console.WriteLine("Both counters finished.");
    }
}