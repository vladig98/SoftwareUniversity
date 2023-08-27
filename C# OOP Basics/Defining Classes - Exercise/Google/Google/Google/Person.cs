using System;
using System.Collections.Generic;
using System.Text;

namespace Google
{
    public class Person
    {
        public string Name { get; set; }
        public Company _Company { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public List<Parent> Parents { get; set; }
        public List<Child> Children { get; set; }
        public Car _Car { get; set; }

        public Person(string name)
        {
            Name = name;
            Pokemons = new List<Pokemon>();
            Parents = new List<Parent>();
            Children = new List<Child>();
        }

        public void AddPokemon(Pokemon pokemon)
        {
            Pokemons.Add(pokemon);
        }

        public void AddParent(Parent parent)
        {
            Parents.Add(parent);
        }

        public void AddChild(Child child)
        {
            Children.Add(child);
        }

        public void AddCar(Car car)
        {
            _Car = car;
        }

        public void AddCompany(Company company)
        {
            _Company = company;
        }

        public override string ToString()
        {
            string result = $"{Name}\r\nCompany:\r\n";

            if (_Company != null)
            {
                result += $"{_Company.CompanyName} {_Company.Department} {_Company.Salary:F2}\r\n";
            }

            result += $"Car:\r\n";

            if (_Car != null)
            {
                result += $"{_Car.Model} {_Car.Speed}\r\n";
            }

            result += $"Pokemon:\r\n";

            foreach (var pokemon in Pokemons)
            {
                result += $"{pokemon.Name} {pokemon.Type}\r\n";
            }

            result += "Parents:\r\n";

            foreach (var parent in Parents)
            {
                result += $"{parent.Name} {parent.BirthDate}\r\n";
            }

            result += "Children:\r\n";

            foreach (var child in Children)
            {
                result += $"{child.Name} {child.BirthDate}\r\n";
            }

            return result;
        }
    }
}
