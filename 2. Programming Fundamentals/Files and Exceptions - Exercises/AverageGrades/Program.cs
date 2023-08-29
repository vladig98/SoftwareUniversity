using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"..\..\..\";
            string[] input = File.ReadAllLines(path + "input.txt");
            int until = int.Parse(input[0]);
            List<Student> students = new List<Student>();
            List<string> results = new List<string>();

            for (int i = 1; i <= until; i++)
            {
                string[] tokens = input[i].Split(" ").ToArray();

                Student student = new Student();
                student.Name = tokens[0];
                student.Grades = tokens.Skip(1).Select(double.Parse).ToList<double>();

                students.Add(student);
            }

            students = students.Where(x => x.Average >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.Average).ToList<Student>();

            foreach (var item in students)
            {
                results.Add($"{item.Name} -> {item.Average.ToString("F2")}");
            }

            File.WriteAllLines(path + "output.txt", results);
        }

        public class Student
        {
            public string Name { get; set; }

            public List<double> Grades { get; set; }

            public double Average => Grades.Average();
        }
    }
}
