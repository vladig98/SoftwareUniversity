using ExtendedDatabase;
using NUnit.Framework;
using System;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        private Database People;
        private Database FullPeople;
        private Person person1;
        private Person person2;
        private Person person3;

        [SetUp]
        public void SetUp()
        {
            People = new Database();

            Person[] people = new Person[16];

            for (int i = 0; i < 16; i++)
            {
                people[i] = new Person((i + 1), $"Pesho{(i + 1)}");
            }

            FullPeople = new Database(people);

            person1 = new Person(1, "Pesho");
            person2 = new Person(2, "Pesho");
            person3 = new Person(1, "Gosho");
        }

        [Test]
        public void CanYouAddAPersonWithTheSameName()
        {
            People.Add(person1);

            Assert.Throws<InvalidOperationException>(() => People.Add(person2), "You should not add people with the same name.");
        }

        [Test]
        public void CanYouAddPersonWithTheSameId()
        {
            People.Add(person1);

            Assert.Throws<InvalidOperationException>(() => People.Add(person3), "You should not add people with the same id.");
        }

        [Test]
        public void CanYouAddPeopleToDatabase()
        {
            People.Add(person1);

            Assert.That(People.Fetch(), 
                Is.EqualTo(new[] { person1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }));
        }

        [Test]
        public void CanYouRemoveAPersonFromTheDatabase()
        {
            FullPeople.Remove();

            Assert.That(FullPeople.Fetch().Last(), Is.EqualTo(null), "You should be removing a person when the database is full.");
        }

        [Test]
        public void CanYouRemoveAPersonFromAnEmptyDatabase()
        {
            Assert.Throws<InvalidOperationException>(() => People.Remove(), "You shouldn't remove a person when the database is empty.");
        }

        [Test]
        public void CanYouFindAPersonByUsername()
        {
            People.Add(person1);

            Assert.That(People.FindByUsername("Pesho"), Is.EqualTo(person1), "You should find a person using a username.");
        }

        [Test]
        public void CanYouFindANonExistantPersonByUsername()
        {
            Assert.Throws<InvalidOperationException>(() => People.FindByUsername("Pesho2"), 
                "You should throw an exception if there are no people found by that username.");
        }

        [Test]
        public void CanYouFindAPersonByUsernameWithAnInvalidName()
        {
            Assert.Throws<ArgumentNullException>(() => People.FindByUsername(""),
                "You should throw an exception if the username parameter is invalid.");
        }

        [Test]
        public void CanYouFindAPersonByUsernameCaseSensitive()
        {
            People.Add(person1);

            Assert.Throws<InvalidOperationException>(() => People.FindByUsername("PESHO"),
                "You should keep the case sensitivity for each person's name.");
        }

        [Test]
        public void CanYouFindAPersonById()
        {
            People.Add(person1);

            Assert.That(People.FindById(1), Is.EqualTo(person1), "You should find people using an id.");
        }

        [Test]
        public void CanYouFindAPersonWithAnIdPointingToAnEmptySpotInTheDatabase()
        {
            People.Add(person1);

            Assert.Throws<InvalidOperationException>(() => People.FindById(5), 
                "You should throw an exception when there is no person with that Id.");
        }

        [Test]
        public void CanYouFindAPersonWithANegativeId()
        {
            People.Add(person1);

            Assert.Throws<ArgumentOutOfRangeException>(() => People.FindById(-1),
                "You should throw an exception when the id is negative.");
        }

        [Test]
        public void Fetch()
        {
            People.Add(person1);

            Assert.That(People.Fetch(), Is.EqualTo(
                new[] { person1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }));
        }

        [Test]
        public void CanYouCreateADatabaseWithMoreThan16People()
        {
            Assert.Throws<InvalidOperationException>(() =>
                new Database(FullPeople.Fetch().Concat(new[] { new Person(17, "Pesho17") }).ToArray()),
                "You should have no more than 16 people in your database.");
        }

        [Test]
        public void CreateADatabase()
        {
            Database db = new Database(person1);

            Assert.That(db.Fetch(),
                Is.EqualTo(new[] { person1, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null }),
                "You should be creating a database.");
        }
    }
}
