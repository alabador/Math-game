using HelloWorld;
using System;
using static System.Formats.Asn1.AsnWriter;

Menu menu = new Menu();

string? name = GetName();
DateTime date = DateTime.UtcNow;

List<string> games = new List<string>();

string GetName()
{
    Console.WriteLine(@$"Let's play a math game!
What's your name?
");
    return Console.ReadLine();
}

menu.ShowMenu(name, date);