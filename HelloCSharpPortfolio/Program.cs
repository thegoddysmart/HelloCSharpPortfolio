using System;

class Program
{
    static void Main(string[] args)
    {
        // asking for the user's input
        Console.Write("What is your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();

        int age = int.Parse(ageInput);

        Console.WriteLine($"\nHello, {name}! You are {age} years old.");
        Console.WriteLine("Welcome to the world of thegoddysmart!");
    }
}