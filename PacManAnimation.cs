using System;
using System.Threading;
using System.Xml.Linq;
class Program
{
    static void Main()
    {
        string line = “------------"; // dots Pac-Man will eat
    int length = line.Length;
        for (int i = 0; i < length; i++)

        { // Pac-Man eats the dot -> blink effect
            Console.Write("\r" + new string(' ', i) + "C" + line.Substring(i + 1));
            Thread.Sleep(200); // Pac-Man arrives
            Console.Write("\r" + new string(' ', i + 1) + line.Substring(i + 1));
            Thread.Sleep(200); // Dot disappears (blink)
        }

        Console.Write("\r" + new string(' ', length) + "C"); // Pac-Man at end
        Console.WriteLine("\n\nGame Over! Pac-Man ate all the dots!");
    }
}
