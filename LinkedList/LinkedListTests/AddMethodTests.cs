using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;

namespace LinkedListTests
{
    [TestClass]
    public class AddMethodTests
    {
        [TestMethod]
        public void TestAddValueEmpty()
        {
            var list = LinkedListFactory.Create();
            
            list.Add("value");
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
    }
}
