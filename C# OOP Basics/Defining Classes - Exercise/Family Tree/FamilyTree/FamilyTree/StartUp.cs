using System;
using System.Collections.Generic;
using System.Linq;

namespace FamilyTree
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string personToLookFor = input;

            List<Person> people = new List<Person>();

            input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputTokens = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries);

                if (inputTokens.Length > 1)
                {
                    Person personParent = new Person(inputTokens[0]);
                    Person personChild = new Person(inputTokens[1]);

                    if (people.Where(x => x.Name != null).Any(x => x.Name == inputTokens[0]) || people.Where(x => x.BirthDate != null).Any(x => x.BirthDate == inputTokens[0]))
                    {
                        personParent = people.Where(x => x.Name == inputTokens[0]).FirstOrDefault();

                        if (personParent == null)
                        {
                            personParent = people.Where(x => x.BirthDate == inputTokens[0]).FirstOrDefault();
                        }
                    }
                    else
                    {
                        if (!people.Where(x => x.Name != null).Any(x => x.Name == personParent.Name) && 
                            !people.Where(x => x.BirthDate != null).Any(x => x.BirthDate == personParent.BirthDate))
                        {
                            people.Add(personParent);
                        }
                    }

                    if (people.Where(x => x.Name != null).Any(x => x.Name == inputTokens[1]) || people.Where(x => x.BirthDate != null).Any(x => x.BirthDate == inputTokens[1]))
                    {
                        personChild = people.Where(x => x.Name == inputTokens[1]).FirstOrDefault();

                        if (personChild == null)
                        {
                            personChild = people.Where(x => x.BirthDate == inputTokens[1]).FirstOrDefault();
                        }
                    }
                    else
                    {
                        if (!people.Where(x => x.Name != null).Any(x => x.Name == personChild.Name) &&
                            !people.Where(x => x.BirthDate != null).Any(x => x.BirthDate == personChild.BirthDate))
                        {
                            people.Add(personChild);
                        }
                    }

                    personParent.Children.Add(personChild);
                    personChild.Parents.Add(personParent);
                }
                else
                {
                    inputTokens = input.Split(" ");

                    string personName = inputTokens[0] + " " + inputTokens[1];
                    string personBirthDate = inputTokens[2];

                    Person personWithSameName = people.Where(x => x.Name == personName).FirstOrDefault();
                    Person personWithSameBirthDate = people.Where(x => x.BirthDate == personBirthDate).FirstOrDefault();

                    Person combinedPerson = new Person(personName);

                    if (personWithSameName != null)
                    {
                        people.Remove(personWithSameName);
                    }
                    else
                    {
                        personWithSameName = new Person("");
                    }

                    if (personWithSameBirthDate != null)
                    {
                        people.Remove(personWithSameBirthDate);
                    }
                    else
                    {
                        personWithSameBirthDate = new Person("");
                    }

                    combinedPerson.BirthDate = personBirthDate;
                    combinedPerson.Parents = personWithSameName.Parents.Count == 0 ? personWithSameBirthDate.Parents : personWithSameName.Parents;
                    combinedPerson.Children = personWithSameName.Children.Count == 0 ? personWithSameBirthDate.Children : personWithSameName.Children;

                    people.Add(combinedPerson);

                    foreach (var p in people)
                    {
                        if (p.Parents.Contains(personWithSameName) || p.Parents.Contains(personWithSameBirthDate))
                        {
                            if (p.Parents.Contains(personWithSameName))
                            {
                                p.Parents.Remove(personWithSameName);
                            }

                            if (p.Parents.Contains(personWithSameBirthDate))
                            {
                                p.Parents.Remove(personWithSameBirthDate);
                            }

                            p.Parents.Add(combinedPerson);
                        }

                        if (p.Children.Contains(personWithSameName) || p.Children.Contains(personWithSameBirthDate))
                        {
                            if (p.Children.Contains(personWithSameName))
                            {
                                p.Children.Remove(personWithSameName);
                            }

                            if (p.Children.Contains(personWithSameBirthDate))
                            {
                                p.Children.Remove(personWithSameBirthDate);
                            }

                            p.Children.Add(combinedPerson);
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Person person = people.Where(x => x.Name == personToLookFor).FirstOrDefault();

            if (person == null)
            {
                person = people.Where(x => x.BirthDate == personToLookFor).FirstOrDefault();
            }

            Console.WriteLine(person.Name + " " + person.BirthDate);
            Console.WriteLine("Parents:");

            if (person.Parents.Any())
            {
                foreach (var parent in person.Parents)
                {
                    Console.WriteLine(parent.Name + " " + parent.BirthDate);
                }
            }

            Console.WriteLine("Children:");

            if (person.Children.Any())
            {
                foreach (var child in person.Children)
                {
                    Console.WriteLine(child.Name + " " + child.BirthDate);
                }
            }
        }
    }
}
