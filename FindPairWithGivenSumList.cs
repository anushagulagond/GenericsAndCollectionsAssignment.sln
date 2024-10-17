using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsAndCollectionsAssignment
{
    internal class FindPairWithGivenSumList
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

            Console.WriteLine("Give the Sum, to which you want to find pair in list");
            int? Givensum=int.Parse(Console.ReadLine());
            int Sum ;
            for(int i=0;i<list.Count();i++)
            {
                Sum = 0;
                List<int> Result = new List<int>();
                if (list[i] <= Givensum)
                {
                    Sum = Sum + list[i];
                    Result.Add(list[i]);
                    for (int j = i + 1; j < list.Count(); j++)
                    {
                        if (list[j] + Sum == Givensum)
                        {
                            Sum += list[j];
                            Result.Add(list[j]);
                            break;
                        }
                        
                    }
                    if (Sum == Givensum)
                    {
                        foreach (var item in Result)
                        {
                            Console.Write(item + " ");
                        }
                        Console.WriteLine();
                    }
                } 
            }
        }
    }
}
