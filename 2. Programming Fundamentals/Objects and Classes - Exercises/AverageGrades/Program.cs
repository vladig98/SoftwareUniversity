using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int until = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < until; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ").ToArray();

                Student student = new Student();
                student.Name = tokens[0];
                student.Grades = tokens.Skip(1).Select(double.Parse).ToList<double>();

                students.Add(student);
            }

            students = students.Where(x => x.Average >= 5).OrderBy(x => x.Name).ThenByDescending(x => x.Average).ToList<Student>();

            foreach (var item in students)
            {
                Console.WriteLine($"{item.Name} -> {item.Average.ToString("F2")}");
            }
        }

        public class Student
        {
            public string Name { get; set; }

            public List<double> Grades { get; set; }

            public double Average => Grades.Average();
        }
    }
}
