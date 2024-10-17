using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    internal class SwapInList
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);
            list.Add(8);
            list.Add(9);
            list.Add(10);

            int right = 0;
            int left = list.Count() - 1;
            while (right < left)
            {
                int temp = list[right];
                list[right] = list[left];
                list[left] = temp;
                //(list[right], list[left]) = (list[left], list[right]);
                right++;
                left--;
            }

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
