using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();
            double grade = double.Parse(Console.ReadLine());

            if (!students.ContainsKey(name))
            {
                students[name] = new List<double>();
            }

            students[name].Add(grade);
        }

        var filteredStudents = new List<KeyValuePair<string, List<double>>>();

        foreach (var pair in students)
        {
            if (pair.Value.Average() >= 4.50)
            {
                filteredStudents.Add(pair);
            }
        }

        filteredStudents.Sort((a, b) => b.Value.Average().CompareTo(a.Value.Average()));

        foreach (var pair in filteredStudents)
        {
            string name = pair.Key;
            double averageGrade = pair.Value.Average();

            Console.WriteLine($"{name} –> {averageGrade:F2}");
        }
    }
}
