// See https://aka.ms/new-console-template for more information
using System;

class Hello
{
    static void Main()
    {
        Console.WriteLine("Hello, World");

        var texto = "lorem imput text for bla bla bla bla";
        Console.WriteLine(texto);

        Console.WriteLine("whats your name?");
        var name = Console.ReadLine();
        var currentDate = DateTime.Now;

        Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}!");
        Console.Write($"{Environment.NewLine}Press any key to exit...");
        Console.ReadKey(true);
    }
}
