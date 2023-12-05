using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, decimal> prices = new Dictionary<string, decimal>();
        Dictionary<string, int> quantities = new Dictionary<string, int>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "buy")
            {
                break;
            }

            string[] productInfo = input.Split();
            string name = productInfo[0];
            decimal price = decimal.Parse(productInfo[1]);
            int quantity = int.Parse(productInfo[2]);

            if (!prices.ContainsKey(name))
            {
                prices[name] = 0;
                quantities[name] = 0;
            }

            prices[name] = price;
            quantities[name] += quantity;
        }

        PrintProductInformation(prices, quantities);
    }

    static void PrintProductInformation(Dictionary<string, decimal> prices, Dictionary<string, int> quantities)
    {
        foreach (var pair in prices)
        {
            string productName = pair.Key;
            decimal price = pair.Value;
            int quantity = quantities[productName];
            decimal totalPrice = price * quantity;

            Console.WriteLine($"{productName} -> {totalPrice:F2}");
        }
    }
}
