using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            Indexer indexerArray1 = new Indexer(arr, 1, 5);

            Console.WriteLine("Array with range {1, 5}:\n");

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("indexerArray1[{0}] = {1}", i, indexerArray1[i]);
            }

            Console.WriteLine();


            Indexer indexerArray2 = new Indexer(arr, -5, 1);

            Console.WriteLine("Array with range {-5, -1}:\n");

            for (int i = -5; i <= -1; i++)
            {
                Console.WriteLine("indexerArray2[{0}] = {1}", i, indexerArray2[i]);
            }

            Console.WriteLine();

            Console.WriteLine("Press any key to exit the program.");
            Console.ReadKey();
        }
    }
}
