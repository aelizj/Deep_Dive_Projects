using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Lists;


namespace LinkedListTests
{
    [TestClass]
    public class LinkedListItemTests
    {
        [TestMethod]
        public void TestValue()
        {
            var i = new LinkedListItem("item");
        }

        [TestMethod]
        public void TestNextValueEmpty()
        {
            var i = new LinkedListItem("item");
            
            Assert.AreEqual(i.NextValue, null);
        }
        
        public void TestAddItemEmpty()
        {

        }

        public void TestNextItemEmpty()
        {

        }

        public void TestGetItem()
        {
            
        }

        public void TestReplaceItem()
        {

        }
    }
}
