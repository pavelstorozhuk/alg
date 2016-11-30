using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
            HeapSort heapSort = new HeapSort(10);
            for (int i = 0; i < array.Length; i++)
            {
                heapSort.Push(array[i]);
            }
            heapSort.Print();

           for (int i = 0; i < array.Length; i++)
           {
                Console.Write(heapSort.Pop()+" ");
           }
            Console.ReadKey();
        }
    }
}
