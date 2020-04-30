using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;
using System.Collections.Generic;

namespace LinkedListTests
{
    [TestClass]
    public class ListTests
    {
        [TestMethod]
        public void TestCountEmpty()
        {
            var list = LinkedListFactory.Create();
            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void TestFirstElementEmpty()
        {
            var list = LinkedListFactory.Create();
            Assert.AreEqual(list.FirstValue, null);
        }

        [TestMethod]
        public void TestNextValueEmpty()
        {
            var list = LinkedListFactory.Create();
            Assert.AreEqual(list.NextElement, null);
        }

        [TestMethod]
        public void TestLastValueEmpty()
        {
            var list = LinkedListFactory.Create();
            Assert.AreEqual(list.LastValue, null);
        }

        [TestMethod]
        public void TestAddValueEmpty()
        {
            var list = LinkedListFactory.Create();
            list.Add("Hello");
        }

        [TestMethod]
        public void TestAddValue()
        {
            var list = LinkedListFactory.Create();

            list.Add("value");

            Assert.AreEqual(list.FirstValue, "value");
            Assert.AreEqual(list.Count, 1);
            Assert.AreEqual(list.NextElement, null);
        }

        [TestMethod]
        public void TestAddTwice()
        {
            var list = LinkedListFactory.Create();

            list.Add("value");

            Assert.AreEqual(list.FirstValue, "value");
            Assert.AreEqual(list.Count, 1);
            Assert.AreEqual(list.NextElement, null);

            list.Add("value2");

            Assert.AreEqual(list.FirstValue, "value");
            Assert.AreEqual(list.Count, 2);
            Assert.AreEqual(list.NextElement, null);
        }

        [TestMethod]
        public void TestRemove()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");

            list.Remove(1);

            Assert.AreEqual(list.Count, 2);
            Assert.AreEqual(list.FirstValue, "value1");
            Assert.AreEqual(list.LastValue, "value3");
        }

        [TestMethod]
        public void TestGetOutOfBounds()
        {
            var list = LinkedListFactory.Create();

           

        }
    }
}
