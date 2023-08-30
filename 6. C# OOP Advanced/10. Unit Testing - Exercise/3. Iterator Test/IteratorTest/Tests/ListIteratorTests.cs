using IteratorTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace Tests
{
    public class ListIteratorTests
    {
        [Test]
        public void TestListIteratorConstructorWithoutACollection()
        {
            var ex = Assert.Throws<ArgumentNullException>(() => new ListIterator(null));

            Assert.That(ex.Message, Is.EqualTo("Value cannot be null."));
        }

        [Test]
        public void TestIfYouCanMoveTheIndexOfTheList()
        {
            List<string> elements = new List<string>() { "Pesho", "Gosho" };
            var list = new ListIterator(elements);

            var result = list.Move();

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void TestIfYouCanMoveToAHigherIndexThanTheCollectionsNumberOfElements()
        {
            List<string> elements = new List<string>() { "Pesho", "Gosho" };
            var list = new ListIterator(elements);

            var result = list.Move();
            result = list.Move();
            result = list.Move();
            result = list.Move();

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void TestIfCollectionHasNoNextElements()
        {
            List<string> elements = new List<string>() { "Pesho" };
            var list = new ListIterator(elements);

            var result = list.HasNext();

            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void TestIfCollectionHasNextElements()
        {
            List<string> elements = new List<string>() { "Pesho", "Gosho" };
            var list = new ListIterator(elements);

            var result = list.HasNext();

            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void TestToPrintWithAnEmptyCollection()
        {
            var elements = new List<string>();
            var list = new ListIterator(elements);

            var ex = Assert.Throws<InvalidOperationException>(() => list.Print());

            Assert.That(ex.Message, Is.EqualTo("Invalid Operation!"));
        }

        [Test]
        public void TestIfListCanPrintElements()
        {
            var elements = new List<string>() { "Gosho", "Pesho" };
            var list = new ListIterator(elements);

            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            list.Print();

            Assert.That(stringWriter.ToString().Trim(new[] {'\r', '\n'}), Is.EqualTo("Gosho"));
        }
    }
}
