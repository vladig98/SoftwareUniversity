using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> students = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(" ");
                string name = inputTokens[0];
                decimal mark = decimal.Parse(inputTokens[1]);

                if (students.ContainsKey(name))
                {
                    students[name].Add(mark);
                }
                else
                {
                    students.Add(name, new List<decimal> { mark });
                }
            }

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value.Select(x => x.ToString("F2")))} (avg: {student.Value.Average().ToString("F2")})");
            }
        }
    }
}
