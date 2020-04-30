using Lists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    internal class LinkedList : ILinkedList
    {
        public int Count { get; set; }
        public string FirstValue { get; }
        public string LastValue { get; }
        public ILinkedList NextElement { get; }
        public LinkedListItem Item;

        public void Add(string value)
        {
            if (Count == 0)
            {
                Item = new LinkedListItem(value);
                Count += 1;
            }
            else
            {
                Item.AddItem(value);
                Count += 1;
            }
        }

        public string Get(int index)
        {
            if ((index > Count - 1) || (index < 1))
            {
                throw new IndexOutOfRangeException();
            }
            return Item.GetItem(index);
        }

        public string Remove(int index)
        {
            if ((index > Count - 1) || (index < 1))
            {
                throw new IndexOutOfRangeException();
            }
            Count -= 1;
            Item.ReplaceItem(index, NextElement.FirstValue);
            return "";
        }
    }
}
