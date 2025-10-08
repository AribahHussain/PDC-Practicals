using System;
using System.Threading;
class Timers
{
    public void Timer1()
    {
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"Timer1: {i}\t(delay 500ms)");
            Thread.Sleep(500);
        }
    }
    public void Timer2()
    {
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine($"\tTimer2: {i}\t(delay 700ms)");
            Thread.Sleep(700);
        }
    }
}
class Program
{
    static void Main()
    {
        Timers t = new Timers();
        Thread thread1 = new Thread(t.Timer1);
        Thread thread2 = new Thread(t.Timer2);
        thread1.Name = "Timer1";
        thread2.Name = "Timer2";
        thread1.Start();