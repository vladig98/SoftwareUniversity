using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<string, List<string>> doktori = new Dictionary<string, List<string>>();
            //Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();


            //string command = Console.ReadLine();
            //while (command != "Output")
            //{
            //    string[] jetoni = command.Split();
            //    var departament = jetoni[0];
            //    var purvoIme = jetoni[1];
            //    var vtoroIme = jetoni[2];
            //    var pacient = jetoni[3];
            //    var cqloIme = purvoIme + vtoroIme;

            //    if (!doktori.ContainsKey(purvoIme + vtoroIme))
            //    {
            //        doktori[cqloIme] = new List<string>();
            //    }
            //    if (!departments.ContainsKey(departament))
            //    {
            //        departments[departament] = new List<List<string>>();
            //        for (int stai = 0; stai < 20; stai++)
            //        {
            //            departments[departament].Add(new List<string>());
            //        }
            //    }

            //    bool imaMqsto = departments[departament].SelectMany(x => x).Count() < 60;
            //    if (imaMqsto)
            //    {
            //        int staq = 0;
            //        doktori[cqloIme].Add(pacient);
            //        for (int st = 0; st < departments[departament].Count; st++)
            //        {
            //            if (departments[departament][st].Count < 3)
            //            {
            //                staq = st;
            //                break;
            //            }
            //        }
            //        departments[departament][staq].Add(pacient);
            //    }

            //    command = Console.ReadLine();
            //}

            //command = Console.ReadLine();

            //while (command != "End")
            //{
            //    string[] args = command.Split();

            //    if (args.Length == 1)
            //    {
            //        Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
            //    }
            //    else if (args.Length == 2 && int.TryParse(args[1], out int staq))
            //    {
            //        Console.WriteLine(string.Join("\n", departments[args[0]][staq - 1].OrderBy(x => x)));
            //    }
            //    else
            //    {
            //        Console.WriteLine(string.Join("\n", doktori[args[0] + args[1]].OrderBy(x => x)));
            //    }
            //    command = Console.ReadLine();
            //}

            const string output = "Output";
            const string end = "End";

            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();

            string command = Console.ReadLine();

            while (command != output)
            {
                string[] inputTokens = command.Split();

                var departament = inputTokens[0];
                var firstName = inputTokens[1];
                var lastName = inputTokens[2];
                var patient = inputTokens[3];
                var fullName = firstName + lastName;

                if (!doctors.ContainsKey(fullName))
                {
                    doctors[fullName] = new List<string>();
                }

                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();

                    for (int i = 0; i < 20; i++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                bool canBeAdmitted = departments[departament].SelectMany(x => x).Count() < 60;

                if (canBeAdmitted)
                {
                    int room = 0;

                    doctors[fullName].Add(patient);

                    for (int i = 0; i < departments[departament].Count; i++)
                    {
                        if (departments[departament][i].Count < 3)
                        {
                            room = i;
                            break;
                        }
                    }
                    departments[departament][room].Add(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != end)
            {
                string[] inputTokens = command.Split();

                if (inputTokens.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments[inputTokens[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (inputTokens.Length == 2 && int.TryParse(inputTokens[1], out int room))
                {
                    Console.WriteLine(string.Join("\n", departments[inputTokens[0]][room - 1].OrderBy(x => x)));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors[inputTokens[0] + inputTokens[1]].OrderBy(x => x)));
                }

                command = Console.ReadLine();
            }
        }
    }
}
