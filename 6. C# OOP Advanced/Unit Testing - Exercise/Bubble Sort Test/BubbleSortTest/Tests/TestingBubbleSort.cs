using BubbleSortTest;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Tests
{
    public class TestingBubbleSort
    {
        [Test]
        public void TestTheBubbleSortingAlgorithm()
        {
            List<int> numbers = new List<int>() { 5, 4, 9, 1, 3, 10, 15, 19, 2, 0, -7, 38, -8, 1 };
            List<int> sorted = new List<int>() { -8, -7, 0, 1, 1, 2, 3, 4, 5, 9, 10, 15, 19, 38 };

            Bubble bubble = new Bubble(numbers);
            var result = bubble.BubbleSort();

            Assert.That(result, Is.EqualTo(sorted));
        }
    }
}
