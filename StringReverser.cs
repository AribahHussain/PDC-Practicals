using System;
class Program
{
    static string ReverseString(string input)
    {
        char[] chars = input.ToCharArray(); // convert string to char array
        Array.Reverse(chars); // reverse array
        return new string(chars); // convert back to string
    }
    static void Main()
    {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        string reversed = ReverseString(userInput); // call method
        Console.WriteLine("Reversed string: " + reversed);
    }
}