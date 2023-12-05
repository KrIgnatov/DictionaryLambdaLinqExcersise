using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

        while (true)
        {
            string input = Console.ReadLine();

            if (input == "End")
            {
                break;
            }

            string[] newID = input.Split(" -> ");
            string companyName = newID[0];
            string employeeId = newID[1];

            if (!companies.ContainsKey(companyName))
            {
                companies[companyName] = new List<string>();
            }

            if (!companies[companyName].Contains(employeeId))
            {
                companies[companyName].Add(employeeId);
            }
        }

        foreach (var pair in companies)
        {
            string companyName = pair.Key;
            List<string> employees = pair.Value;

            Console.WriteLine(companyName);
            foreach (var employeeId in employees)
            {
                Console.WriteLine($"-- {employeeId}");
            }
        }
    }
}
