using Lists;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    internal class LinkedList : ILinkedList
    {
        public int Count { get; set; }
        public string FirstValue { get; set; }
        public string LastValue { get; set; }
        public ILinkedList NextElement { get; set;}
        public LinkedListItem Item;


        public void Add(string value)
        {
            if (Count == 0)
            {
                Item = new LinkedListItem(value);
                Count += 1;
                FirstValue = FirstItem();
                LastValue = LastItem();
            }
            else
            {
                Item.AddItem(value);
                Count += 1;
                FirstValue = FirstItem();
                LastValue = LastItem();
            }
        }

        public string Get(int index)
        {
            if ((index > Count - 1) || (index < 0))
            {
                throw new IndexOutOfRangeException();
            }
            return Item.GetItem(index);
        }

        public string Remove(int index)
        {
            if ((index > Count - 1) || (index < 0))
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Count -= 1;
                var a = Item.ReplaceItem(index, Item.NextValue);
                FirstValue = FirstItem();
                LastValue = LastItem();
                return a;
            }
        }

        public void PrintList(LinkedList list)
        {
            while (Item.NextValue != null)
            {
                Console.WriteLine(Item);
            }
        }

        public string FirstItem()
        {
            return Item.GetItem(0);
        }

        public string LastItem()
        {
            return Item.GetItem(Count - 1);
        }
    }
}
