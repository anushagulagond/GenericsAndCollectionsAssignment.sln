using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    internal class ReverseLinkedList
    {
        public static void Main(string[] args) {
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(1);
            list.AddLast(3);
            list.AddLast(4);
            list.AddLast(5);
            list.AddFirst(8);
            var index = list.Find(1);
            list.AddBefore(index, 0);
            list.AddAfter(index, 2);
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*************************");
            int Count = list.Count();
            for(int i = Count-1; i >= 0; i--)
            {
                Console.WriteLine(list.ElementAt(i));
            }
            Console.WriteLine("**************");
            
            foreach (var item in list.Reverse())
            {
                Console.WriteLine(item);
            }
        }
    }
}
