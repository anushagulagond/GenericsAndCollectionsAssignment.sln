using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    internal class FlattenListOfLists
    {
        public static void Main(string[] args)
        {
            List<List<int>> list = new List<List<int>>
            {
                new List<int>{1,2,3,4},
                new List<int>{5,8,10 },
                new List<int>{12,19,6,5 }
            };

            //var FlattendResult = list.SelectMany(x => x);

            //foreach(var i in FlattendResult)
            //{
            //    Console.WriteLine(i);
            //}

            foreach (var item in list)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }
        }
    }
}
