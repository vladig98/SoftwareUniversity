using IntegrationTests;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitTesting
{
    public class Tests
    {
        Engine engine;

        public Tests()
        {
            engine = new Engine();
        }

        [Test]
        public void TestIfYouCanAddACategory()
        {
            engine.Reset();
            engine.AddCategory("test");
            Assert.That(engine.Categories.Count, Is.EqualTo(1));
        }

        [Test]
        public void TestIfTheCategoryIsSavedCorrectly()
        {
            engine.Reset();
            engine.AddCategory("test");

            Assert.That(engine.Categories[0].Name, Is.EqualTo("test"));
        }

        [Test]
        public void TestIfYouCanAddACategoryWithTheSameName()
        { 
            engine.Reset();
            engine.AddCategory("test");
            Assert.Throws<InvalidOperationException>(() => engine.AddCategory("test"));
        }

        [Test]
        public void TestToAddAnInvalidCategory()
        {
            engine.Reset();
            Assert.Throws<ArgumentNullException>(() => engine.AddCategory(""));
        }

        [Test]
        public void TestIfYouCanAddAUser()
        {
            engine.Reset();
            engine.AddUser("test");
            Assert.That(engine.Users.Count, Is.EqualTo(1));
        }

        [Test]
        public void TestIfTheUserIsSavedCorrectly()
        {
            engine.Reset();
            engine.AddUser("test");

            Assert.That(engine.Users[0].Name, Is.EqualTo("test"));
        }

        [Test]
        public void TestIfYouCanAddAUserWithTheSameName()
        {
            engine.Reset();
            engine.AddUser("test");
            Assert.Throws<InvalidOperationException>(() => engine.AddUser("test"));
        }

        [Test]
        public void TestToAddAnInvalidUser()
        {
            engine.Reset();
            Assert.Throws<ArgumentNullException>(() => engine.AddUser(""));
        }

        [Test]
        public void TestIfYouCanRemoveANonExistentCategory()
        {
            engine.Reset();
            engine.AddCategory("test");
            Assert.Throws<InvalidOperationException>(() => engine.RemoveCategory("test2"));
        }

        [Test]
        public void TestIfYouCanRemoveACategoryFromAnEmptyList()
        {
            engine.Reset();
            Assert.Throws<InvalidOperationException>(() => engine.RemoveCategory("test"));
        }

        [Test]
        public void TestIfYouCanRemoveAnInvalidCategory()
        {
            engine.Reset();
            Assert.Throws<ArgumentNullException>(() => engine.RemoveCategory(""));
        }

        [Test]
        public void TestIfWeRemoveACategory()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.RemoveCategory("test");
            Assert.That(engine.Categories.Count, Is.EqualTo(0));
        }

        [Test]
        public void TestIfWeRemoveTheRightCategory()
        {
            engine.Reset();
            engine.AddCategory("test2");
            engine.AddCategory("test");
            engine.RemoveCategory("test");
            Assert.That(engine.Categories.Any(x => x.Name == "test"), Is.EqualTo(false));
        }

        [Test]
        public void TestIfYouCanRemoveCategoriesFromAnEmptyList()
        {
            engine.Reset();
            List<string> namesToRemove = new List<string>() { "test", "test2", "test3" };
            Assert.Throws<InvalidOperationException>(() => engine.RemoveCategories(namesToRemove));
        }

        [Test]
        public void TestIfYouCanRemoveInvalidCategories()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            List<string> namesToRemove = new List<string>() { "test", "test2", "test3" };
            Assert.Throws<ArgumentException>(() => engine.RemoveCategories(namesToRemove));
        }

        [Test]
        public void TestIfYouCanRemoveNoCategories()
        {
            engine.Reset();
            List<string> namesToRemove = new List<string>() { };
            Assert.Throws<ArgumentNullException>(() => engine.RemoveCategories(namesToRemove));
        }

        [Test]
        public void TestIfYouCanRemoveCategories()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            engine.AddCategory("test3");
            List<string> namesToRemove = new List<string>() { "test", "test2", "test3" };
            engine.RemoveCategories(namesToRemove);
            Assert.That(engine.Categories.Count, Is.EqualTo(0));
        }

        [Test]
        public void TestIfYouCanAssignAChildToACategoryWithInvalidArguments()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            Assert.Throws<ArgumentNullException>(() => engine.AssignChildCategory("", ""));
        }

        [Test]
        public void TestIfYouCanAssignAChildToACategoryWithNonExistentCategory()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            Assert.Throws<ArgumentException>(() => engine.AssignChildCategory("test2", "test2"));
        }

        [Test]
        public void TestIfYouCanAssignAChildToACategoryWithNonExistentChild()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            Assert.Throws<ArgumentException>(() => engine.AssignChildCategory("test", "test"));
        }

        [Test]
        public void TestIfYouCanAssignAChildToItself()
        {
            engine.Reset();
            engine.AddCategory("test");
            Assert.Throws<ArgumentException>(() => engine.AssignChildCategory("test", "test"));
        }

        [Test]
        public void TestIfYouCanAssignAChildToACategory()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            engine.AssignChildCategory("test", "test2");
            Assert.That(engine.Categories.Where(x => x.Name == "test").FirstOrDefault().GetChildren().Any(x => x.Name == "test2"), 
                Is.EqualTo(true));
        }

        [Test]
        public void TestIfYouCanAssignAUserToACategoryWithInvalidArguments()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddUser("test2");
            Assert.Throws<ArgumentNullException>(() => engine.AssignUserCategory("", ""));
        }

        [Test]
        public void TestIfYouCanAssignAUserToACategoryWithInvalidCategory()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddUser("test2");
            Assert.Throws<ArgumentException>(() => engine.AssignUserCategory("test2", "test2"));
        }

        [Test]
        public void TestIfYouCanAssignAUserToACategoryWithInvalidUser()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddUser("test2");
            Assert.Throws<ArgumentException>(() => engine.AssignUserCategory("test", "test"));
        }

        [Test]
        public void TestIfYouCanAssignAChildThatIsAlreadyAssigned()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            engine.AddCategory("test3");
            engine.AssignChildCategory("test", "test2");
            Assert.Throws<InvalidOperationException>(() => engine.AssignChildCategory("test3", "test2"));
        }

        [Test]
        public void TestIfYouCanAssignAUserThatIsAlreadyAssigned()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            engine.AddUser("test3");
            engine.AssignUserCategory("test", "test3");
            Assert.Throws<InvalidOperationException>(() => engine.AssignUserCategory("test2", "test3"));
        }

        [Test]
        public void TestIfYouCanAssignAUserToACategory()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddUser("test2");
            engine.AssignUserCategory("test", "test2");
            Assert.That(engine.Users.Where(x => x.Name == "test2").FirstOrDefault().GetCategories().Any(x => x.Name == "test")
                && engine.Categories.Where(x => x.Name == "test").FirstOrDefault().GetUsers().Any(x => x.Name == "test2"), Is.EqualTo(true));
        }

        [Test]
        public void TestIfYouCanRemoveAChildWithInvalidArguments()
        {
            engine.Reset();
            Assert.Throws<ArgumentNullException>(() => engine.RemoveChild("", ""));
        }

        [Test]
        public void TestIfYouCanRemoveAChildWithNonExistentArguments()
        {
            engine.Reset();
            Assert.Throws<ArgumentException>(() => engine.RemoveChild("test", "test2"));
        }

        [Test]
        public void TestIfYouCanRemoveAChildThatHasBeenAssignedToAnotherCategory()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            engine.AddCategory("test3");
            engine.AssignChildCategory("test", "test2");
            Assert.Throws<InvalidOperationException>(() => engine.RemoveChild("test3", "test2"));
        }

        [Test]
        public void TestIfYouCanRemoveAChildThatHasNotBeenAssignedToTheCategory()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            engine.AddCategory("test3");
            engine.AssignChildCategory("test", "test2");
            Assert.Throws<InvalidOperationException>(() => engine.RemoveChild("test", "test3"));
        }

        [Test]
        public void TestIfYouCanRemoveAChild()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            engine.AddCategory("test3");
            engine.AssignChildCategory("test", "test2");
            engine.RemoveChild("test", "test2");
            Assert.That(engine.Categories.Where(x => x.Name == "test").FirstOrDefault().GetChildren().Any(x => x.Name == "test2"), 
                Is.EqualTo(false));
        }

        [Test]
        public void TestIfYouCanRemoveChildrenWithInvalidArguments()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("tes2");
            Assert.Throws<ArgumentNullException>(() => engine.RemoveChildren("", new List<string>()));
        }

        [Test]
        public void TestIfYouCanRemoveChildrenWithInvalidChildren()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("tes2");
            List<string> childrenToRemove = new List<string>() { "", "" };
            Assert.Throws<ArgumentNullException>(() => engine.RemoveChildren("test", childrenToRemove));
        }

        [Test]
        public void TestIfYouCanRemoveChildrenWithInvalidCategory()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("tes2");
            List<string> childrenToRemove = new List<string>() { "", "" };
            Assert.Throws<ArgumentNullException>(() => engine.RemoveChildren("test3", childrenToRemove));
        }

        [Test]
        public void TestIfYouCanRemoveChildrenThatAreAssignedToAnotherCategory()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            engine.AddCategory("test3");
            engine.AddCategory("test4");
            engine.AssignChildCategory("test", "test2");
            engine.AssignChildCategory("test3", "test4");
            List<string> childrenToRemove = new List<string>() { "test2", "test4" };
            Assert.Throws<InvalidOperationException>(() => engine.RemoveChildren("test3", childrenToRemove));
        }

        [Test]
        public void TestIfYouCanRemoveChildren()
        {
            engine.Reset();
            engine.AddCategory("test");
            engine.AddCategory("test2");
            engine.AddCategory("test3");
            engine.AddCategory("test4");
            engine.AssignChildCategory("test", "test2");
            engine.AssignChildCategory("test", "test3");
            engine.AssignChildCategory("test", "test4");
            List<string> childrenToRemove = new List<string>() { "test2", "test3", "test4" };
            engine.RemoveChildren("test", childrenToRemove);
            Assert.That(engine.Categories.Where(x => x.Name == "test").FirstOrDefault().GetChildren()
                .Any(x => x.Name == "test2" || x.Name == "test3" || x.Name == "test4"), Is.EqualTo(false));
        }
    }
}
