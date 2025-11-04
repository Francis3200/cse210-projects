using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Program!");
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
    }
}