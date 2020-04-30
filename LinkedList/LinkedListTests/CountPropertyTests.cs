using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;

namespace LinkedListTests 
{
    [TestClass]
    public class CountPropertyTests
    {
        [TestMethod]
        public void TestCountEmpty()
        {
            var list = LinkedListFactory.Create();
            Assert.AreEqual(list.Count, 0);
        }

        [TestMethod]
        public void TestCount()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");

            Assert.AreEqual(list.Count, 2);
        }

        [TestMethod]
        public void TestCountUponAdd()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");

            Assert.AreEqual(list.Count, 1);

            list.Add("value2");

            Assert.AreEqual(list.Count, 2);
        }

        [TestMethod]
        public void TestCountUponRemove()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");

            Assert.AreEqual(list.Count, 2);

            list.Remove(0);

            Assert.AreEqual(list.Count, 1);
        }
    }
}
