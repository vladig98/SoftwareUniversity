using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedyTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //long vhod = long.Parse(Console.ReadLine());
            //string[] seif = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //var torba = new Dictionary<string, Dictionary<string, long>>();
            //long zlato = 0;
            //long kamuni = 0;
            //long mangizi = 0;

            //for (int i = 0; i < seif.Length; i += 2)
            //{
            //    string name = seif[i];
            //    long broika = long.Parse(seif[i + 1]);

            //    string kvoE = string.Empty;

            //    if (name.Length == 3)
            //    {
            //        kvoE = "Cash";
            //    }
            //    else if (name.ToLower().EndsWith("gem"))
            //    {
            //        kvoE = "Gem";
            //    }
            //    else if (name.ToLower() == "gold")
            //    {
            //        kvoE = "Gold";
            //    }

            //    if (kvoE == "")
            //    {
            //        continue;
            //    }
            //    else if (vhod < torba.Values.Select(x => x.Values.Sum()).Sum() + broika)
            //    {
            //        continue;
            //    }

            //    switch (kvoE)
            //    {
            //        case "Gem":
            //            if (!torba.ContainsKey(kvoE))
            //            {
            //                if (torba.ContainsKey("Gold"))
            //                {
            //                    if (broika > torba["Gold"].Values.Sum())
            //                    {
            //                        continue;
            //                    }
            //                }
            //                else
            //                {
            //                    continue;
            //                }
            //            }
            //            else if (torba[kvoE].Values.Sum() + broika > torba["Gold"].Values.Sum())
            //            {
            //                continue;
            //            }
            //            break;
            //        case "Cash":
            //            if (!torba.ContainsKey(kvoE))
            //            {
            //                if (torba.ContainsKey("Gem"))
            //                {
            //                    if (broika > torba["Gem"].Values.Sum())
            //                    {
            //                        continue;
            //                    }
            //                }
            //                else
            //                {
            //                    continue;
            //                }
            //            }
            //            else if (torba[kvoE].Values.Sum() + broika > torba["Gem"].Values.Sum())
            //            {
            //                continue;
            //            }
            //            break;
            //    }

            //    if (!torba.ContainsKey(kvoE))
            //    {
            //        torba[kvoE] = new Dictionary<string, long>();
            //    }

            //    if (!torba[kvoE].ContainsKey(name))
            //    {
            //        torba[kvoE][name] = 0;
            //    }

            //    torba[kvoE][name] += broika;
            //    if (kvoE == "Gold")
            //    {
            //        zlato += broika;
            //    }
            //    else if (kvoE == "Gem")
            //    {
            //        kamuni += broika;
            //    }
            //    else if (kvoE == "Cash")
            //    {
            //        mangizi += broika;
            //    }
            //}

            //foreach (var x in torba)
            //{
            //    Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
            //    foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
            //    {
            //        Console.WriteLine($"##{item2.Key} - {item2.Value}");
            //    }
            //}

            long bagCapaity = long.Parse(Console.ReadLine());
            string[] inputTokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var bag = new Dictionary<string, Dictionary<string, long>>();

            for (int i = 0; i < inputTokens.Length; i += 2)
            {
                string item = inputTokens[i];
                long amount = long.Parse(inputTokens[i + 1]);

                string category = string.Empty;

                if (item.Length == 3)
                {
                    category = "Cash";
                }
                else if (item.ToLower().EndsWith("gem"))
                {
                    category = "Gem";
                }
                else if (item.ToLower() == "gold")
                {
                    category = "Gold";
                }

                if (category == "")
                {
                    continue;
                }
                else if (bagCapaity < bag.Values.Select(x => x.Values.Sum()).Sum() + amount)
                {
                    continue;
                }

                switch (category)
                {
                    case "Gem":
                        if (!bag.ContainsKey(category))
                        {
                            if (bag.ContainsKey("Gold"))
                            {
                                if (amount > bag["Gold"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[category].Values.Sum() + amount > bag["Gold"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                    case "Cash":
                        if (!bag.ContainsKey(category))
                        {
                            if (bag.ContainsKey("Gem"))
                            {
                                if (amount > bag["Gem"].Values.Sum())
                                {
                                    continue;
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (bag[category].Values.Sum() + amount > bag["Gem"].Values.Sum())
                        {
                            continue;
                        }
                        break;
                }

                if (!bag.ContainsKey(category))
                {
                    bag[category] = new Dictionary<string, long>();
                }

                if (!bag[category].ContainsKey(item))
                {
                    bag[category][item] = 0;
                }

                bag[category][item] += amount;
            }

            foreach (var x in bag)
            {
                Console.WriteLine($"<{x.Key}> ${x.Value.Values.Sum()}");
                foreach (var item2 in x.Value.OrderByDescending(y => y.Key).ThenBy(y => y.Value))
                {
                    Console.WriteLine($"##{item2.Key} - {item2.Value}");
                }
            }
        }
    }
}
