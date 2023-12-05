Dictionary<string, long> resources = new Dictionary<string, long>();

while (true)
{
    string resource = Console.ReadLine();

    if (resource == "stop")
    {
        break;
    }

    long quantity = long.Parse(Console.ReadLine());

    if (!resources.ContainsKey(resource))
    {
        resources[resource] = 0;
    }

    resources[resource] += quantity;
}

PrintResourceQuantities(resources);

    static void PrintResourceQuantities(Dictionary<string, long> resources)
{
    foreach (var pair in resources)
    {
        string resource = pair.Key;
        long quantity = pair.Value;

        Console.WriteLine($"{resource} -> {quantity}");
    }
}