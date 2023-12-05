using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, string> parkingDatabase = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();
            string action = command[0];
            string username = command[1];

            if (action == "register")
            {
                string licensePlate = command[2];
                if (parkingDatabase.ContainsKey(username))
                {
                    Console.WriteLine($"ERROR: already registered with plate number {parkingDatabase[username]}");
                }
                else
                {
                    parkingDatabase[username] = licensePlate;
                    Console.WriteLine($"{username} registered {licensePlate} successfully");
                }
            }
            else if (action == "unregister")
            {
                if (parkingDatabase.ContainsKey(username))
                {
                    parkingDatabase.Remove(username);
                    Console.WriteLine($"{username} unregistered successfully");
                }
                else
                {
                    Console.WriteLine($"ERROR: user {username} not found");
                }
            }
        }

        foreach (var pair in parkingDatabase)
        {
            string username = pair.Key;
            string licensePlate = pair.Value;

            Console.WriteLine($"{username} => {licensePlate}");
        }
    }
}
