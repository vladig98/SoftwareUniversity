using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Animals
{
    public class Animal : ISoundProducable
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid input!");
                }
                name = value;
            }
        }

        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid input!");
                }
                age = value;
            }
        }

        private GenderEnum gender;

        public GenderEnum Gender
        {
            get { return gender; }
            set
            {
                gender = value;
            }
        }

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            if (Enum.TryParse(gender.ToLower(), out GenderEnum genderEnum))
            {
                Gender = genderEnum;
            }
            else
            {
                throw new ArgumentException("Invalid input"!);
            }
        }

        public virtual void ProduceSound()
        {
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}{Environment.NewLine}{Name} {Age} {Gender.ToString()[0].ToString().ToUpper() + string.Join("", Gender.ToString().Skip(1).ToArray())}";
        }
    }
}
