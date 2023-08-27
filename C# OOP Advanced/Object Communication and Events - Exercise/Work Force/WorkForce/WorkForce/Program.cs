using System;
using System.Collections.Generic;
using System.Linq;

namespace WorkForce
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Handler handler = new Handler();
            List<Job> jobs = new List<Job>();
            List<IEmployee> employees = new List<IEmployee>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputTokens = input.Split(" ");

                switch (inputTokens[0])
                {
                    case "Job":
                        Job jobToAdd = new Job(handler, employees.Where(x => x.Name == inputTokens[3]).First(),
                            inputTokens[1], int.Parse(inputTokens[2]));
                        jobToAdd.JobUpdate += new JobUpdateEventHandler(handler.OnJobUpdate);
                        jobs.Add(jobToAdd);
                        break;
                    case "StandardEmployee":
                        employees.Add(new StandardEmployee(inputTokens[1]));
                        break;
                    case "PartTimeEmployee":
                        employees.Add(new PartTimeEmployee(inputTokens[1]));
                        break;
                    case "Pass":
                        foreach (var job in jobs)
                        {
                            if (job.HoursOfWorkRequired > 0)
                            {
                                job.Update();
                            }
                        }
                        break;
                    case "Status":
                        foreach (var j in jobs)
                        {
                            if (j.HoursOfWorkRequired > 0)
                            {
                                Console.WriteLine(j);
                            }
                        }
                        break;
                    default:
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
