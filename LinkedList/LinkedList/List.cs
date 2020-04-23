using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class List
    {
        public int Count { get; }
        public string FirstValue { get; }
        public string LastValue { get; }
        public string NextElement { get; }
        public ListItem Item;


        public void AddValue(string value)
        {
            if (Count == 0)
            {
                Item = new ListItem();
            }
            else
            {

            }
        }

        public string GetValue(int index)
        {
            return "hi";
        }

        public void RemoveValue(int index)
        {

        }
    }
}
