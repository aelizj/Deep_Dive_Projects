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

            Console.WriteLine(linkedList.Count);
            Console.WriteLine(linkedList.FirstValue);
            Console.WriteLine(linkedList.NextElement);
            Console.WriteLine(linkedList.LastValue);

            linkedList.Remove(2);
        }
    }
}
