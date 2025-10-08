using System;
class P // Superclass
{
    public int a = 30; // instance variable in superclass
}
class Q : P // Child class inherits from P
{
    public new int a = 50; // hides superclass variable
}
class Program
{
    static void Main(string[] args)
    {
        Q q = new Q(); // object of child class Q
        Console.WriteLine("Value of a using q: " + q.a); // access child variable
        P p = q; // superclass referencing to childclass
        Console.WriteLine("Value of a using superclass reference: " + p.a); // access parent variable
        Console.WriteLine("Value of a using subclass reference: " + q.a); // access child variable
    }
}