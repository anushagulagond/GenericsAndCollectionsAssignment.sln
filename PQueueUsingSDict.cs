using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    public class PriorityQueue<TKey,TValue>
    {
        SortedDictionary<TKey, TValue> Dict;

        public PriorityQueue()
        {
            Dict=new SortedDictionary<TKey, TValue>();
        }

        public void EnQueue(TKey key,TValue value)
        {
            if (!Dict.ContainsKey(key))
            {
                Dict.Add(key, value);
            }
            else
            {
                Dict[key] = value;
            }
        }
        public TValue DeQueue()
        {
            var MinKey = Dict.Keys.GetEnumerator();
            MinKey.MoveNext();
            var MinValue = Dict[MinKey.Current];
            Dict.Remove(MinKey.Current);
            return MinValue;
        }

        public void Display()
        {
            foreach (var kvp in Dict)
            {
                Console.WriteLine(kvp);
            }
        }
    }

    internal class PQueueUsingSDict
    {
        public static void Main(string[] args)
        {
            PriorityQueue<int,string> priorityQueue = new PriorityQueue<int,string>();
            priorityQueue.EnQueue(1, "A");
            priorityQueue.EnQueue(2, "B");
            priorityQueue.EnQueue(3, "C");
            priorityQueue.EnQueue(4, "D");
            priorityQueue.Display();
            Console.WriteLine("********");
            var Popped=priorityQueue.DeQueue();
            Console.WriteLine("Popped ele: " + Popped);
            Console.WriteLine("********");
            priorityQueue.Display();
        }
    }
}
