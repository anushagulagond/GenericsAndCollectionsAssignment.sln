using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    internal class RemoveDuplicates
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(2);
            list.Add(5);
            list.Add(6);
            list.Add(4);

            HashSet<int> set=new HashSet<int>();
            
            foreach(int item in list)
            {
                set.Add(item);
            }
            foreach (int item in set)
            {
                Console.WriteLine(item);
            }
          
        }
    }
}
