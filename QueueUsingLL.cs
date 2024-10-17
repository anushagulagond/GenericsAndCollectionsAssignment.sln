namespace GenericsAndCollectionsAssignment
{
    public class Queue<T>
    {
        public int rear;
        public int front;
        LinkedList<int> list;
        public Queue()
        {
            rear = 0;
            front = 0;
            list= new LinkedList<int>();
        }

        public void EnQueue(int item)
        {
            list.AddLast(item);
            rear++;
        }
        public object DeQueue()
        {
            if(rear==0 && front == 0)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                list.Remove(list.ElementAt(front));
                front++;
            }
            return list;
        }
        public void Display()
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
    internal class QueueUsingLL
    {
        public static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.DeQueue();
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);
            queue.EnQueue(4);
            queue.EnQueue(5);
            queue.EnQueue(6);
            Console.WriteLine("**********");

            queue.Display();

            Console.WriteLine("**********");
            Console.WriteLine("Remove element from queue");
            queue.DeQueue();

            Console.WriteLine("**********");

            queue.Display();

            Console.WriteLine("**********");
        }
    }
}
