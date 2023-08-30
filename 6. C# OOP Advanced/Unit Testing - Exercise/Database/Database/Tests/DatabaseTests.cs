using Database;
using NUnit.Framework;
using System;
using System.Collections;
using System.Linq;

namespace Tests
{
    public class DatabaseTests
    {
        Database.Database db;
        Database.Database fullDb;

        [SetUp]
        public void SetUp()
        {
            db = new Database.Database();
            fullDb = new Database.Database(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16);
        }

        [Test]
        public void IsTheDatabaseCreatedWith16Elements()
        {
            Assert.That(db.Fetch(), Is.EqualTo(Enumerable.Repeat(0, 16).ToArray()), "The database does not contain 16 integers.");
        }

        [Test]
        public void CanTheDatabaseHaveMoreThan16Integers()
        {
            Assert.Throws<InvalidOperationException>(() => new Database.Database(fullDb.Fetch().Concat(new[] { 17 }).ToArray()),
                "The database should not have more than 16 elements.");
        }

        [Test]
        public void CanYouAddAnIntegerToTheDatabase()
        {
            int integerToAdd = 1;

            db.AddNumber(integerToAdd);

            Assert.That(db.Fetch(), Is.EqualTo(new int[] { integerToAdd }.Concat(Enumerable.Repeat(0, 15).ToArray())), "The database cannot add a new number.");
        }

        [Test]
        public void CanYouAddAnIntegerToTheDatabaseIfTheDatabaseIsFull()
        {
            Assert.Throws<InvalidOperationException>(() => fullDb.AddNumber(17), "The database should not add a number when it's full.");
        }

        [Test]
        public void CanYouRemoveAnIntegerFromTheDatabase()
        {
            fullDb.Remove();
            Assert.That(fullDb.Fetch(), Is.EqualTo(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 0 }), 
                "Database should remove an integer when it has elements to remove.");
        }

        [Test]
        public void CanYouRemoveAnIntegerFromAnEmptyDatabase()
        {
            Assert.Throws<InvalidOperationException>(() => db.Remove(), "The database should not remove an element when it's empty.");
        }

        [Test]
        public void DoesTheFetchCommandReturnTheCorrectNumbers()
        {
            Assert.That(fullDb.Fetch(), Is.EqualTo(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }), 
                "The database is not storing the integers correctly.");
        }
    }
}
