using Microsoft.VisualStudio.TestTools.UnitTesting;
using BashSoft.Contracts;
using BashSoft.DataStructures;
using System;
using System.Collections.Generic;

namespace BashSoftTesting
{
    [TestClass]
    public class OrderedDataStructureTester
    {
        private ISimpleOrderedBag<string> names;

        [TestMethod]
        public void TestEmptyCtor()
        {
            names = new SimpleSortedList<string>();
            Assert.AreEqual(names.Capacity, 16);
            Assert.AreEqual(names.Size, 0);
        }

        [TestMethod]
        public void TestCtorWithInitialCapacity()
        {
            names = new SimpleSortedList<string>(20);
            Assert.AreEqual(names.Capacity, 20);
            Assert.AreEqual(names.Size, 0);
        }

        [TestMethod]
        public void TestCtorWithAllParams()
        {
            names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase, 30);
            Assert.AreEqual(names.Capacity, 30);
            Assert.AreEqual(names.Size, 0);
        }

        [TestMethod]
        public void TestCtorWithInitialComparer()
        {
            names = new SimpleSortedList<string>(StringComparer.OrdinalIgnoreCase);
            Assert.AreEqual(names.Capacity, 16);
            Assert.AreEqual(names.Size, 0);
        }

        [TestInitialize]
        public void SetUp()
        {
            names = new SimpleSortedList<string>();
        }

        [TestMethod]
        public void TestAddIncreasesSize()
        {
            names.Add("Nasko");
            Assert.AreEqual(1, names.Size);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAddNullThrowsException()
        {
            names.Add(null);
        }

        [TestMethod]
        public void TestAddUnsortedDataIsHeldSorted()
        {
            names.Add("Rosen");
            names.Add("Georgi");
            names.Add("Balkan");

            string[] ordered = { "Balkan", "Georgi", "Rosen" };

            int i = 0;

            foreach (string name in names)
            {
                Assert.AreEqual(name, ordered[i++]);
            }
        }

        [TestMethod]
        public void TestAddingMoreThanInitialCapacity()
        {
            for (int i = 0; i < 17; i++)
            {
                names.Add($"Name{i}");
            }

            Assert.AreEqual(names.Size, 17);
            Assert.AreNotEqual(names.Capacity, 16);
        }

        [TestMethod]
        public void TestAddingAllFromCollectionIncreasesSize()
        {
            List<string> namesToAdd = new List<string>() { "Pesho", "Gosho" };

            names.AddAll(namesToAdd);

            Assert.AreEqual(names.Size, 2);
        }

        [TestMethod]
        [ExpectedException (typeof(ArgumentNullException))]
        public void TestAddingAllFromNullThrowsException()
        {
            names.AddAll(null);
        }

        [TestMethod]
        public void TestAddAllKeepsSorted()
        {
            List<string> namesToAdd = new List<string>() { "Pesho", "Gosho", "Bratan", "Shisho" };
            names.AddAll(namesToAdd);
            int i = 0;

            string[] ordered = new string[4] { "Bratan", "Gosho", "Pesho", "Shisho" };

            foreach (var name in names)
            {
                Assert.AreEqual(ordered[i++], name);
            }
        }

        [TestMethod]
        public void TestRemoveValidElementDecreasesSize()
        {
            names.Add("Peter");
            names.Remove("Peter");

            Assert.AreEqual(names.Size, 0);
        }

        [TestMethod]
        public void TestRemoveValidElementRemovesSelectedOne()
        {
            names.Add("Ivan");
            names.Add("Nasko");
            names.Remove("Ivan");

            string[] result = new string[1] { "Nasko" };

            foreach (var name in names)
            {
                Assert.AreEqual(name, result[0]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestRemovingNullThrowsException()
        {
            names.Remove(null);
        }

        [TestMethod]
        [ExpectedException (typeof(ArgumentNullException))]
        public void TestJoinWithNull()
        {
            names.AddAll(new[] { "Pesho", "Gosho", "Ivan" });

            names.JoinWith(null);
        }

        [TestMethod]
        public void TestJoinWorksFine()
        {
            names.AddAll(new[] { "Pesho", "Gosho", "Ivan" });

            string output = "Gosho, Ivan, Pesho";

            Assert.AreEqual(output, names.JoinWith(", "));
        }
    }
}
