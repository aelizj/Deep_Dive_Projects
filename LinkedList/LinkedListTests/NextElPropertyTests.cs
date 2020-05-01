using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;

namespace LinkedListTests
{
    [TestClass]
    public class NextElementPropertyTests
    {
        [TestMethod]
        public void TestNextElementEmpty()
        {
            var list = LinkedListFactory.Create();
            
            Assert.AreEqual(list.NextElement, null);
        }

        [TestMethod]
        public void TestNextElement()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");

            Assert.AreEqual(list.NextElement, null);
        }
    }
}
