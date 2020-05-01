using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;

namespace LinkedListTests
{
    [TestClass]
    public class RemoveMethodTests
    {
        [TestMethod]
        public void TestRemoveFromBeginning()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");

            list.Remove(0);

            Assert.AreEqual(list.Count, 2);
            Assert.AreEqual(list.FirstValue, "value2");
            Assert.AreEqual(list.LastValue, "value3");
        }

        [TestMethod]
        public void TestRemoveFromMiddle()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");
            list.Add("value4"); // removed
            list.Add("value5");
            list.Add("value6");

            list.Remove(3);

            Assert.AreEqual(list.Count, 5);
            Assert.AreEqual(list.FirstValue, "value1");
            Assert.AreEqual(list.LastValue, "value6");
        }

        [TestMethod]
        public void TestRemoveFromEnd()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");

            list.Remove(2);

            Assert.AreEqual(list.Count, 2);
            Assert.AreEqual(list.FirstValue, "value1");
            Assert.AreEqual(list.LastValue, "value2");
        }

        [TestMethod]
        public void TestRemoveTwiceFromBeginning()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1"); //removed first
            list.Add("value2"); //removed second
            list.Add("value3");
            list.Add("value4");
            list.Add("value5");

            list.Remove(0);

            Assert.AreEqual(list.Count, 4);
            Assert.AreEqual(list.FirstValue, "value2");
            Assert.AreEqual(list.LastValue, "value5");

            list.Remove(0);

            Assert.AreEqual(list.Count, 3);
            Assert.AreEqual(list.FirstValue, "value3");
            Assert.AreEqual(list.LastValue, "value5");
        }

        [TestMethod]
        public void TestRemoveTwiceFromMiddle()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3"); //removed first
            list.Add("value4"); //removed second
            list.Add("value5");

            list.Remove(2);

            Assert.AreEqual(list.Count, 4);
            Assert.AreEqual(list.FirstValue, "value1");
            Assert.AreEqual(list.LastValue, "value5");

            list.Remove(2);

            Assert.AreEqual(list.Count, 3);
            Assert.AreEqual(list.FirstValue, "value1");
            Assert.AreEqual(list.LastValue, "value5");
        }

        [TestMethod]
        public void TestRemoveTwiceFromEnd()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");
            list.Add("value4"); //removed second
            list.Add("value5"); //removed first

            list.Remove(4);

            Assert.AreEqual(list.Count, 4);
            Assert.AreEqual(list.FirstValue, "value1");
            Assert.AreEqual(list.LastValue, "value4");

            list.Remove(3);

            Assert.AreEqual(list.Count, 3);
            Assert.AreEqual(list.FirstValue, "value1");
            Assert.AreEqual(list.LastValue, "value3");
        }

        [TestMethod]
        public void TestRemoveOutOfBounds()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");

            try
            {
                list.Remove(1);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }
}
