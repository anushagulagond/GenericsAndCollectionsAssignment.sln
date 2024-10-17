using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    internal class TupleToDict
    {
        public static void Main(string[] args)
        {
            Tuple<int, string> tuple1 = Tuple.Create(1, "A");
            Tuple<int,string> tuple2=Tuple.Create(2, "B");
            Tuple<int, string> tuple3 = Tuple.Create(3, "C");
            Tuple<int, string> tuple4 = Tuple.Create(4, "D");

            Dictionary<int,string> Dict= new Dictionary<int,string>();
            Dict.Add(tuple1.Item1,tuple1.Item2);
            Dict.Add(tuple2.Item1, tuple2.Item2);
            Dict.Add(tuple3.Item1, tuple3.Item2);
            Dict.Add(tuple4.Item1, tuple4.Item2);

            foreach(var item in Dict)
            {
                Console.WriteLine(item);
            }
        }
    }
}
