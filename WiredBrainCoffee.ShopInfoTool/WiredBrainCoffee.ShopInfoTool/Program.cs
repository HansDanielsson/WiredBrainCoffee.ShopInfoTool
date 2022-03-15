﻿// See https://aka.ms/new-console-template for more information
using WiredBrainCoffee.DataAccess;

Console.WriteLine("Wired Brain Coffee - Shop Info Tool!");

Console.WriteLine("Write 'help' to list available coffee shop commands");

var coffeeShopDataProvider = new CoffeeShopDataProvider();

while (true)
{
    var line = Console.ReadLine();

    var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();

    if (string.Equals("help", line, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("> Available coffee shop commands:");
        foreach (var coffeeShop in coffeeShops)
        {
            Console.WriteLine($"> " + coffeeShop.Location);
        }
    }
}