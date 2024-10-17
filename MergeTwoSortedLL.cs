using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    internal class MergeTwoSortedLL
    {
        public static void Main(string[] args)
        {
            LinkedList<int> list1 = new LinkedList<int>();
            LinkedList<int> list2 = new LinkedList<int>();
            list1.AddLast(2);
            list2.AddLast(3);
            list1.AddLast(1);
            list2.AddLast(8);
            list1.AddLast(5);
            list2.AddLast(4);
            list1.AddLast(6);
            list2.AddLast(15);
            LinkedList<int> FinalList = new LinkedList<int>();
            foreach (var item in list1)
            {
                FinalList.AddLast(item);
            }
            foreach (var item in list2)
            {
                FinalList.AddLast(item);
            }
            //int Count = FinalList.Count();
            
            foreach(var item in FinalList.Order())
            {
                Console.WriteLine(item);
            }
        }
    }
}
