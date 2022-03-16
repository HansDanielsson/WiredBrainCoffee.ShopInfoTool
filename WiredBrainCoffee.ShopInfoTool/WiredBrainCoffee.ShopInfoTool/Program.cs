// See https://aka.ms/new-console-template for more information
using WiredBrainCoffee.DataAccess;
using WiredBrainCoffee.ShopInfoTool;

Console.WriteLine("Wired Brain Coffee - Shop Info Tool!");

Console.WriteLine("Write 'help' to list available coffee shop commands, " +
    "write 'quit' to exit application");

var coffeeShopDataProvider = new CoffeeShopDataProvider();

while (true)
{
    var line = Console.ReadLine();

    if (string.Equals("quit", line, StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    var coffeeShops = coffeeShopDataProvider.LoadCoffeeShops();

    var commandHandler =
    string.Equals("help", line, StringComparison.OrdinalIgnoreCase)
    ? new HelpCommandHandler(coffeeShops) as ICommandHandler
    : new CoffeeShopCommandHandler(coffeeShops, line);

    commandHandler.HandleCommand();
}