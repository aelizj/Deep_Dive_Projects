using Lists;
using System;

namespace Project
{    
    public class Program
    {
        public static void Main(string[] args)
        {
            var linkedList = LinkedListFactory.Create();

            linkedList.Add("one");
            linkedList.Add("two");
            linkedList.Add("three");
            linkedList.Add("four");
            linkedList.Add("five");
            linkedList.Add("six");
            linkedList.Add("seven");

            Console.WriteLine("COUNT, FIRST VALUE, NEXT VALUE, AND LAST VALUE:");
            Console.WriteLine(linkedList.Count);
            Console.WriteLine(linkedList.FirstValue);
            Console.WriteLine(linkedList.NextElement);
            Console.WriteLine(linkedList.LastValue);
            Console.WriteLine("");

            Console.WriteLine("ELEMENTS IN LIST:");
            Console.WriteLine(linkedList.Get(0));
            Console.WriteLine(linkedList.Get(1));
            Console.WriteLine(linkedList.Get(2));
            Console.WriteLine(linkedList.Get(3));
            Console.WriteLine(linkedList.Get(4));
            Console.WriteLine(linkedList.Get(5));
            Console.WriteLine(linkedList.Get(6));
            Console.WriteLine("");

            Console.WriteLine("REMOVING ELEMENT 'five':");
            linkedList.Remove(4);
            Console.WriteLine(linkedList.Count);
            Console.WriteLine(linkedList.FirstValue);
            Console.WriteLine(linkedList.NextElement);
            Console.WriteLine(linkedList.LastValue);
            Console.WriteLine("");

            Console.WriteLine("ELEMENTS IN LIST AFTER REMOVAL:");
            linkedList.Get(5);
            Console.WriteLine("");

        }
    }
}
