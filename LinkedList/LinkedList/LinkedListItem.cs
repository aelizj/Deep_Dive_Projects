using System;
using System.Collections.Generic;
using System.Text;

namespace Lists
{
    internal class LinkedListItem
    {
        public string Value;
        public LinkedListItem NextValue;


        public LinkedListItem(string value)
        {
            Value = value;
        }

        public void AddItem(string value)
        {
            if (NextValue == null)
            {
                NextValue = new LinkedListItem(value);
            }
            else
            {
                NextValue.AddItem(value);
            }
        }

        public string GetItem(int index)
        {
            if (index == 0)
            {
                return Value;
            }
            else
            {
               return NextValue.GetItem(index - 1);
            }
        }

        public string ReplaceItem(int index, LinkedListItem item)
        {
           if (index == 1)
            {
                return NextValue.ReplaceItem(index - 1, item);                
            }
            else if (index == -1)
            {
                return new string($"{item}");
            }
            else
            {
                return ReplaceItem(index - 1, item);                
            }
        }

        public void NextItem()
        {
            var list = new LinkedList();
            list.Add(NextValue.Value);
        }
    }
}
