using System;

Fighter fighter = new Fighter();

Console.Write("Enter the fighter's name: ");
fighter.Name = Console.ReadLine();

Console.Write("Enter the fighter's weight in pounds: ");
fighter.Weight = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"\nFighter: {fighter.Name}");
Console.WriteLine($"Weight: {fighter.Weight} lbs");
Console.WriteLine($"Category: {fighter.Category}");

Console.ReadLine();