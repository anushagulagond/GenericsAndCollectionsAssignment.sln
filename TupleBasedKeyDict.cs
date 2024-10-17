using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    class TupleBasedKeyDict
    {
        public static void Main(string[] args)
        {
            var dictionary = new Dictionary<(int, int, string), string>();

            dictionary.Add((1, 11, "A"), "AAAAAAA");
            dictionary.Add((2, 22, "B"), "BBBBBBB");
            dictionary.Add((3, 33, "C"), "CCCCCCC");
            dictionary.Add((4,44,"D"),"DDDDDDDD");

            foreach(var item in dictionary)
            {
                Console.WriteLine(item);
            }
        }
    }
}
