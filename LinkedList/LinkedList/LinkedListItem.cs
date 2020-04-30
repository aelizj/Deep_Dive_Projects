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
            return "";
        }

        public string ReplaceItem(int index, string nextVal)
        {
            return "";
        }

        public void NextItem()
        {

        }
    }
}
