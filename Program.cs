using System;
using System.Collections.Generic;
using System.Linq;

namespace short_list_20_large_item
{
    class Program
    {
        static void Main(string[] args)
        {
            Random _rand = new Random();
            var results = Enumerable.Range(0, 100)
                                    .Select(r => _rand.Next(100))
                                    .ToList();
            Console.WriteLine("List<int> with length 100 item will be like:");
            printList(results);


            // order by
            int i = 0;
            List<int> filterList = results;
            List<int> orderedList = new List<int>();
            while(i < 20){
                int max = filterList.Max();
                orderedList.Add(max);
                var index = filterList.FindIndex(x => x == max);
                filterList.RemoveAt(index);
                i++;
            }
            foreach(int j in filterList){
                orderedList.Add(j);
            }

            Console.WriteLine("After order by: ");
            // print
            printList(orderedList);

            Console.WriteLine("Finish order by, press any key to end.");
            Console.ReadLine();
        }

        public static void printList(List<int> list){
            foreach(int i in list){
                Console.WriteLine(i);
            }
            Console.WriteLine("length: {0}", list.Count());
        }
    }
}
