using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var familyTree = new List<Person>();
            //string personInput = Console.ReadLine();
            //Person mainPerson = new Person();

            //if (IsBirthday(personInput))
            //{
            //    mainPerson.Birthday = personInput;
            //}
            //else
            //{
            //    mainPerson.Name = personInput;
            //}

            //familyTree.Add(mainPerson);

            //string command;
            //while ((command = Console.ReadLine()) != "End")
            //{
            //    string[] tokens = command.Split(" - ");
            //    if (tokens.Length > 1)
            //    {
            //        string firstPerson = tokens[0];
            //        string secondPerson = tokens[1];

            //        Person currentPerson;

            //        if (IsBirthday(firstPerson))
            //        {
            //            currentPerson = familyTree.FirstOrDefault(p => p.Birthday == firstPerson);

            //            if (currentPerson == null)
            //            {
            //                currentPerson = new Person();
            //                currentPerson.Birthday = firstPerson;
            //                familyTree.Add(currentPerson);
            //            }

            //            SetChild(familyTree, currentPerson, secondPerson);
            //        }
            //        else
            //        {
            //            currentPerson = familyTree.FirstOrDefault(p => p.Name == firstPerson);

            //            if (currentPerson == null)
            //            {
            //                currentPerson = new Person();
            //                currentPerson.Name = firstPerson;
            //                familyTree.Add(currentPerson);
            //            }

            //            SetChild(familyTree, currentPerson, secondPerson);
            //        }
            //    }
            //    else
            //    {
            //        tokens = tokens[0].Split();
            //        string name = $"{tokens[0]} {tokens[1]}";
            //        string birthday = tokens[2];

            //        var person = familyTree.FirstOrDefault(p => p.Name == name || p.Birthday == birthday);
            //        if (person == null)
            //        {
            //            person = new Person();
            //            familyTree.Add(person);
            //        }
            //        person.Name = name;
            //        person.Birthday = birthday;

            //        int index = familyTree.IndexOf(person) + 1;
            //        int count = familyTree.Count - index;

            //        Person[] copy = new Person[count];
            //        familyTree.CopyTo(index, copy, 0, count);

            //        Person copyPerson = copy.FirstOrDefault(p => p.Name == name || p.Birthday == birthday);

            //        if (copyPerson != null)
            //        {
            //            familyTree.Remove(copyPerson);
            //            person.Parents.AddRange(copyPerson.Parents);
            //            person.Parents = person.Parents.Distinct().ToList();

            //            person.Children.AddRange(copyPerson.Children);
            //            person.Children = person.Children.Distinct().ToList();
            //        }
            //    }
            //}

            //Console.WriteLine(mainPerson);
            //Console.WriteLine("Parents:");
            //foreach (var p in mainPerson.Parents)
            //{
            //    Console.WriteLine(p);
            //}
            //Console.WriteLine("Children:");
            //foreach (var c in mainPerson.Children)
            //{
            //    Console.WriteLine(c);
            //}

            var familyTree = new List<Person>();
            string personInput = Console.ReadLine();
            Person mainPerson = new Person();

            if (IsBirthday(personInput))
            {
                mainPerson.BirthDay = personInput;
            }
            else
            {
                mainPerson.Name = personInput;
            }

            familyTree.Add(mainPerson);

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] tokens = command.Split(" - ");
                if (tokens.Length > 1)
                {
                    string firstPerson = tokens[0];
                    string secondPerson = tokens[1];

                    Person currentPerson;

                    if (IsBirthday(firstPerson))
                    {
                        currentPerson = familyTree.FirstOrDefault(p => p.BirthDay == firstPerson);

                        if (currentPerson == null)
                        {
                            currentPerson = new Person();
                            currentPerson.BirthDay = firstPerson;
                            familyTree.Add(currentPerson);
                        }

                        SetChild(familyTree, currentPerson, secondPerson);
                    }
                    else
                    {
                        currentPerson = familyTree.FirstOrDefault(p => p.Name == firstPerson);

                        if (currentPerson == null)
                        {
                            currentPerson = new Person();
                            currentPerson.Name = firstPerson;
                            familyTree.Add(currentPerson);
                        }

                        SetChild(familyTree, currentPerson, secondPerson);
                    }
                }
                else
                {
                    tokens = tokens[0].Split();
                    string name = $"{tokens[0]} {tokens[1]}";
                    string birthday = tokens[2];

                    var person = familyTree.FirstOrDefault(p => p.Name == name || p.BirthDay == birthday);

                    List<Person> duplicates = familyTree.Where(p => p.BirthDay == birthday || p.Name == name).Skip(1).ToList();

                    if (person == null)
                    {
                        person = new Person();
                        familyTree.Add(person);
                    }
                    person.Name = name;
                    person.BirthDay = birthday;

                    for (int i = duplicates.Count - 1; i >= 0; i--)
                    {
                        Person duplicate = duplicates[i];

                        person.Parents.AddRange(duplicate.Parents);
                        person.Parents = person.Parents.Distinct().ToList();

                        person.Children.AddRange(duplicate.Children);
                        person.Children = person.Children.Distinct().ToList();

                        familyTree.Remove(duplicate);
                    }

                    for (int i = 0; i < familyTree.Count; i++)
                    {
                        for (int j = familyTree[i].Parents.Count - 1; j >= 0; j--)
                        {
                            if (duplicates.Contains(familyTree[i].Parents[j]))
                            {
                                familyTree[i].Parents.Remove(familyTree[i].Parents[j]);
                                familyTree[i].Parents.Add(person);
                            }
                        }

                        familyTree[i].Parents = familyTree[i].Parents.Distinct().ToList();

                        for (int j = familyTree[i].Children.Count - 1; j >= 0; j--)
                        {
                            if (duplicates.Contains(familyTree[i].Children[j]))
                            {
                                familyTree[i].Children.Remove(familyTree[i].Children[j]);
                                familyTree[i].Children.Add(person);
                            }
                        }

                        familyTree[i].Children = familyTree[i].Children.Distinct().ToList();
                    }
                }
            }

            Console.WriteLine(mainPerson);
            Console.WriteLine("Parents:");
            foreach (var p in mainPerson.Parents)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine("Children:");
            foreach (var c in mainPerson.Children)
            {
                Console.WriteLine(c);
            }
        }

        //private static void SetChild(List<Person> familyTree, Person parentPerson, string child)
        //{
        //    var childPerson = new Person();

        //    if (IsBirthday(child))
        //    {
        //        if (!familyTree.Any(p => p.Birthday == child))
        //        {
        //            childPerson.Birthday = child;
        //        }
        //        else
        //        {
        //            childPerson = familyTree.First(p => p.Birthday == child);
        //        }
        //    }
        //    else
        //    {
        //        if (!familyTree.Any(p => p.Name == child))
        //        {
        //            childPerson.Name = child;
        //        }
        //        else
        //        {
        //            childPerson = familyTree.First(p => p.Name == child);
        //        }
        //    }

        //    parentPerson.Children.Add(childPerson);
        //    childPerson.Parents.Add(parentPerson);
        //    familyTree.Add(childPerson);
        //}

        //static bool IsBirthday(string input)
        //{
        //    return Char.IsDigit(input[0]);
        //}

        private static void SetChild(List<Person> familyTree, Person parentPerson, string child)
        {
            var childPerson = familyTree.FirstOrDefault(x => x.Name == child || x.BirthDay == child);

            if (childPerson == null)
            {
                childPerson = new Person();
            }

            if (IsBirthday(child))
            {
                childPerson.BirthDay = child;
            }
            else
            {
                childPerson.Name = child;
            }

            parentPerson.Children.Add(childPerson);
            childPerson.Parents.Add(parentPerson);
            if (!familyTree.Any(x => x.Name == child || x.BirthDay == child))
            {
                familyTree.Add(childPerson);
            }
        }

        static bool IsBirthday(string input)
        {
            return Char.IsDigit(input[0]);
        }
    }
}
