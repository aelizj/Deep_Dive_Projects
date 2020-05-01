using Lists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    public static class LinkedListFactory
    {
        public static ILinkedList Create()
        {
            return new LinkedList();
        }
    }
}
