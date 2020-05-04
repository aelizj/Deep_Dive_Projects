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
                var a = Item.GetItem(index);
                var b = Item.ReplaceItem(index, Item.NextValue);
                Count -= 1;

                FirstValue = FirstItem();
                LastValue = LastItem();

                Console.WriteLine("");
                Console.WriteLine($"Index = {index}");
                Console.WriteLine($"Item = {Item}");
                Console.WriteLine($"Item.NextValue = {Item.NextValue.Value}");
                Console.WriteLine($"Item.Value = {Item.Value}");
                Console.WriteLine($"Item.GetItem(index): {a}");
                Console.WriteLine($"Item.ReplaceItem(index, nextValue): {b}");
                Console.WriteLine("");
                
                return a;
                
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
