using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;

namespace LinkedListTests
{
    [TestClass]
    public class FirstLastValuePropertyTests
    {
        [TestMethod]
        public void TestFirstValueEmpty()
        {
            var list = LinkedListFactory.Create();
            Assert.AreEqual(list.FirstValue, null);
        }

        [TestMethod]
        public void TestFirstValue()
        {
            var list = LinkedListFactory.Create();

            list.Add("value");

            Assert.AreEqual(list.Get(0), list.FirstValue);
        }

        [TestMethod]
        public void TestLastValueEmpty()
        {
            var list = LinkedListFactory.Create();
            Assert.AreEqual(list.LastValue, null);
        }

        [TestMethod]
        public void TestLastValue()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");

            Assert.AreEqual(list.Get(list.Count - 1), list.LastValue);
            Assert.AreEqual(list.Get(2), "value3");
        }

        [TestMethod]
        public void TestFirstAndLastValue()
        {
            var list = LinkedListFactory.Create();

            list.Add("value");

            Assert.AreEqual(list.Get(0), list.FirstValue);
            Assert.AreEqual(list.Get(0), list.LastValue);
        }


        [TestMethod]
        public void TestLastValueUponAddTwice()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");

            Assert.AreEqual(list.Get(1), list.LastValue);
            Assert.AreEqual(list.Get(1), "value2");


            list.Add("value3");

            Assert.AreEqual(list.Get(2), list.LastValue);
            Assert.AreEqual(list.Get(2), "value3");
        }

        [TestMethod]
        public void TestFirstValueUponRemoveFromBeginning()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");

            list.Remove(0);

            Assert.AreEqual(list.Get(0), list.FirstValue);
            Assert.AreEqual(list.Get(0), "value2");

        }

        [TestMethod]
        public void TestLastValueUponRemoveFromBeginning()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");

            list.Remove(0);

            Assert.AreEqual(list.Get(list.Count - 1), list.LastValue);
            Assert.AreEqual(list.Get(1), list.LastValue);
            Assert.AreEqual(list.Get(1), "value3");
        }


        [TestMethod]
        public void TestFirstValueUponRemoveFromMiddle()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");

            list.Remove(1);
            
            Assert.AreEqual(list.Get(0), list.FirstValue);
            Assert.AreEqual(list.Get(0), "value1");
        }

        [TestMethod]
        public void TestLastValueUponRemoveFromMiddle()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");

            list.Remove(1);

            Assert.AreEqual(list.Get(list.Count - 1), list.LastValue);
            Assert.AreEqual(list.Get(1), list.LastValue);
            Assert.AreEqual(list.Get(1), "value3");
        }


        [TestMethod]
        public void TestFirstValueUponRemoveFromEnd()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");

            list.Remove(2);

            Assert.AreEqual(list.Get(0), list.FirstValue);
            Assert.AreEqual(list.Get(0), "value1");
        }

        [TestMethod]
        public void TestLastValueUponRemoveFromEnd()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");

            list.Remove(2);

            Assert.AreEqual(list.Get(list.Count - 1), list.LastValue);
            Assert.AreEqual(list.Get(1), list.LastValue);
            Assert.AreEqual(list.Get(1), "value2");
        }
    }
}
