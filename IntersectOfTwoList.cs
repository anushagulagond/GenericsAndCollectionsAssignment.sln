using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    internal class IntersectOfTwoList
    {
        public static void Main(string[] args)
        {
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(8);
            list1.Add(4);
            list1.Add(9);
            list1.Add(6);

            List<int> list2 = new List<int>();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Add(5);
            list2.Add(6);

            foreach(int i in list1)
            {
                foreach(int j in list2)
                {
                    if (i == j)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
