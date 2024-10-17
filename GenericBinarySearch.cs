using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    internal class GenericBinarySearch
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
            Console.WriteLine("Give the Key to be Search");
            int Searchkey=int.Parse(Console.ReadLine());

            int min = 0;
            int max = list.Count()-1;

            while (min <= max)
            {
                int mid=(min+max)/2;
                if (Searchkey == list[mid])
                {
                    Console.WriteLine("Key is present at index " + mid);
                    break;
                }
                else if(Searchkey < list[mid])
                {
                    max = mid - 1;

                }
                else
                {
                    min = mid + 1;
                }
            }
        }
    }
}
