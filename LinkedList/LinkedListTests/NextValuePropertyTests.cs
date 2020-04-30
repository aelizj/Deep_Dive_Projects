using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;

namespace LinkedListTests
{
    [TestClass]
    public class NextValuePropertyTests
    {
        [TestMethod]
        public void TestNextValueEmpty()
        {
            var list = LinkedListFactory.Create();
            Assert.AreEqual(list.NextElement, null);
        }
    }
}
