using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            Person person1 = new Person(10);
            Person person2 = new Person("Pesho", 20);
        }
    }
}
