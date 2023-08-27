using System;
using System.Collections.Generic;
using System.Text;

namespace StudentSystem
{
    public class StudentSystem
    {
        public Dictionary<string, Student> Repo { get; set; }

        public StudentSystem()
        {
            this.Repo = new Dictionary<string, Student>();
        }

        public void ParseCommand()
        {
            string[] inputTokens = Console.ReadLine().Split();

            if (inputTokens[0] == "Create")
            {
                string name = inputTokens[1];
                int age = int.Parse(inputTokens[2]);
                double grade = double.Parse(inputTokens[3]);


                if (!Repo.ContainsKey(name))
                {
                    Student student = new Student(name, age, grade);
                    Repo[name] = student;
                }
            }
            else if (inputTokens[0] == "Show")
            {
                string name = inputTokens[1];
                if (Repo.ContainsKey(name))
                {
                    Student student = Repo[name];
                    string view = $"{student.Name} is {student.Age} years old.";

                    if (student.Grade >= 5.00)
                    {
                        view += " Excellent student.";
                    }
                    else if (student.Grade < 5.00 && student.Grade >= 3.50)
                    {
                        view += " Average student.";
                    }
                    else
                    {
                        view += " Very nice person.";
                    }

                    Console.WriteLine(view);
                }

            }
            else if (inputTokens[0] == "Exit")
            {
                Environment.Exit(0);
            }
        }
    }
}
