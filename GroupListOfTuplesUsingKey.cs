using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    internal class GroupListOfTuplesUsingKey
    {
        public static void Main(string[] args)
        {
            var Tuples = new List<(int, string)>
            {
                (1,"A"),
                (2,"B"),
                (2,"C"),
                (4,"D"),
                (5,"E"),
                (6,"F"),
                (5,"H"),
                (4,"I"),

            };

            var GroupTuples = Tuples.GroupBy(x => x.Item1);

            foreach(var Group in GroupTuples)
            {
                Console.WriteLine("KEY: "+Group.Key );
                foreach(var G in Group)
                {
                    Console.WriteLine(G.Item2);
                }
            }
        }
    }
}
