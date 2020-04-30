using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;

namespace LinkedListTests
{
    [TestClass]
    public class FirstValuePropertyTests
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
        public void TestFirstAndLastValue()
        {
            var list = LinkedListFactory.Create();

            list.Add("value");

            Assert.AreEqual(list.Get(0), list.FirstValue);
            Assert.AreEqual(list.Get(0), list.LastValue);
        }
    }
}
