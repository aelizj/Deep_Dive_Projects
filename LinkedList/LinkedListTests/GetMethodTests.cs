using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lists;

namespace LinkedListTests
{
    [TestClass]
    public class GetMethodTests
    {
        [TestMethod]
        public void TestGetBeginningValue()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");

            Assert.AreEqual(list.Get(0), "value1");
        }

        [TestMethod]
        public void TestGetMiddleValue()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");


            Assert.AreEqual(list.Get(1), "value2");
        }

        [TestMethod]
        public void TestGetEndValue()
        {
            var list = LinkedListFactory.Create();

            list.Add("value1");
            list.Add("value2");
            list.Add("value3");


            Assert.AreEqual(list.Get(2), "value3");
        }

        [TestMethod]
        public void TestGetOutOfBounds()
        {
            var list = LinkedListFactory.Create();

            try
            {
                list.Get(1);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index out of range.");
            }
        }
    }
}
