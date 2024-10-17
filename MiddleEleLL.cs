using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    internal class MiddleEleLL
    {
        public static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddLast("A");
            list.AddLast("B");
            list.AddLast("C");
            list.AddLast("D");
            list.AddLast("E");
            list.AddLast("F");
            list.AddLast("G");
            list.AddLast("H");
            list.AddLast("I");

            int middle = list.Count()/2;
            Console.WriteLine("Middle element: " + list.ElementAt(middle));
        }
    }
}
