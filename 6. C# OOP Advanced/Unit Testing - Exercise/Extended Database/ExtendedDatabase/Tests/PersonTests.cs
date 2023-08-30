using ExtendedDatabase;
using NUnit.Framework;

namespace Tests
{
    public class PersonTests
    {
        private Person person;

        [SetUp]
        public void SetUp()
        {
            person = new Person(1, "Pesho");
        }

        [Test]
        public void TestIfPersonIsCreatedWithTheCorrectId()
        {
             Assert.That(person.Id, Is.EqualTo(1));
        }

        [Test]
        public void TestIfPersonIsCreatedWithTheCorrectName()
        {
             Assert.That(person.Name, Is.EqualTo("Pesho"));
        }
    }
}
