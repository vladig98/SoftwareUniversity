using CustomLinkedList;
using NUnit.Framework;
using System;

namespace Tests
{
    public class Class1
    {
        [Test]
        public void TestTheCountMethod()
        {
            DynamicList<string> list = new DynamicList<string>();

            list.Add("Test");

            Assert.That(list.Count, Is.EqualTo(1));
        }

        [Test]
        public void TestTheAddMethod()
        {
            DynamicList<string> list = new DynamicList<string>();

            list.Add("Test");

            Assert.That(list[0], Is.EqualTo("Test"));
        }

        [Test]
        public void TestIfYouCanAccessTheCorrectElementByIndex()
        {
            DynamicList<string> list = new DynamicList<string>();

            list.Add("Test");
            list.Add("Test2");
            list.Add("Test3");
            list.Add("Test4");

            Assert.That(list[2], Is.EqualTo("Test3"));
        }

        [Test]
        public void TestIfYouCanSetTheCorrectElementByIndex()
        {
            DynamicList<string> list = new DynamicList<string>();

            list.Add("Test");
            list.Add("Test2");
            list.Add("Test3");
            list.Add("Test4");

            list[2] = "Test20";

            Assert.That(list[2], Is.EqualTo("Test20"));
        }

        [Test]
        public void TestIfYouCanRemoveAtAPosition()
        {
            DynamicList<string> list = new DynamicList<string>();

            list.Add("Test");
            list.Add("Test2");
            list.Add("Test3");
            list.Add("Test4");

            string element = list.RemoveAt(2);

            Assert.That(element, Is.EqualTo("Test3"));
        }

        [Test]
        public void TestIfYouCanRemoveAnElement()
        {
            DynamicList<string> list = new DynamicList<string>();

            list.Add("Test");
            list.Add("Test2");
            list.Add("Test3");
            list.Add("Test4");

            int index = list.Remove("Test3");

            Assert.That(index, Is.EqualTo(2));
        }

        [Test]
        public void TestIfYouCanRetrieveTheIndexOfAnItem()
        {
            DynamicList<string> list = new DynamicList<string>();

            list.Add("Test");
            list.Add("Test2");
            list.Add("Test3");
            list.Add("Test4");

            int index = list.IndexOf("Test3");

            Assert.That(index, Is.EqualTo(2));
        }

        [Test]
        public void TestIfContainsWorks()
        {
            DynamicList<string> list = new DynamicList<string>();

            list.Add("Test");
            list.Add("Test2");
            list.Add("Test3");
            list.Add("Test4");

            bool contains = list.Contains("Test3");

            Assert.That(contains, Is.EqualTo(true));
        }

        [Test]
        public void TestIfYouCanAccessByInvalidIndex()
        {
            DynamicList<string> list = new DynamicList<string>();

            string value = "";

            Assert.Throws<ArgumentOutOfRangeException>(() => value = list[5], "You need to enter a valid index");
        }

        [Test]
        public void TestIfYouCanSetByInvalidIndex()
        {
            DynamicList<string> list = new DynamicList<string>();

            string value = "";

            Assert.Throws<ArgumentOutOfRangeException>(() => list[5] = value, "You need to enter a valid index");
        }

        [Test]
        public void TestIfYouCanRemoveAtAPositionWithInvalidIndex()
        {
            DynamicList<string> list = new DynamicList<string>();

            Assert.Throws<ArgumentOutOfRangeException>(() => list.RemoveAt(10), "Enter a valid index");
        }

        [Test]
        public void TestIfYouCanRemoveAnItemThatDoesNotExist()
        {
            DynamicList<string> list = new DynamicList<string>();

            Assert.Throws<InvalidOperationException>(() => list.Remove("test"), "There is no condition for non existent elements");
        }

        [Test]
        public void TestIfYouCanGetTheIndexOfNonExistentElement()
        {
            DynamicList<string> list = new DynamicList<string>();

            Assert.Throws<InvalidOperationException>(() => list.IndexOf("test"), "There is no condition for non existent elements");
        }
    }
}
