using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Console.CursorVisible = false; // Hide cursor for clean animation
        int width = 40;   // Console width for rain area
        int height = 15;  // Console height for rain area
        int loops = 20;   // Number of animation frames
        Random rand = new Random();

        for (int frame = 0; frame < loops; frame++)
        {
            Console.Clear();
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // Randomly decide if this position will have a raindrop
                    if (rand.Next(0, 10) > 7)
                        Console.Write("|");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Thread.Sleep(150); // Pause between frames for animation effect
        }

        Console.Clear();
        Console.CursorVisible = true;
        Console.WriteLine("🌧️ Rain animation ended. Stay dry!");
    }
}
