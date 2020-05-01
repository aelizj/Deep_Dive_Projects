using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;

namespace LinkedListTests
{
    [TestClass]
    public class LastValuePropertyTests
    {
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
        }

        [TestMethod]
        public void TestLastValueUponAdd()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");

            Assert.AreEqual(list.Get(list.Count - 1), list.LastValue);

            list.Add("value3");

            Assert.AreEqual(list.Get(list.Count - 1), list.LastValue);
        }
    }
}
