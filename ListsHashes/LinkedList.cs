using System;
namespace ListsHashes
{
    public class LinkedList
    {
        public int Count { get;}    
        public string FirstValue { get; }
        public string LastValue { get; }
        public string NextElement { get; }
        public ListItem Item;


        public void AddValue(string value)
        {
            if (Count == 0) 
            {
                Item = new ListItem(value);
                Count ++;
                FirstValue = value;
            } 
            else
            {
                Item.AddItem(value);
                Count ++;
                LastValue = value;
            }
        }

        public string GetValue(int index)
        {
            if ((index > Count) || (index < 0))
            {
                return "Error: Invalid Index";
            }
            else
            {
                
            }
        }

        public void RemoveValue(int index)
        {

        }
    }

    public class ListItem
    {
        public string Value;
        public ListItem NextValue = null;


        public ListItem(string value)
        {
            Value = value;
        } 

        public void AddItem(string value)
        {

        }

        public string GetItem(int index)
        {

        }

        public void RemoveItem(int index, string nextVal)
        {

        }

        public LinkedList NextItem
        {

        }
    }
}