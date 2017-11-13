using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Indexer
    {
        int[] arr { get; set; }
        int lowerIndex { get; set; }
        int higherIndex { get; set; }

        public Indexer(int[] arr, int lowerIndex, int higherIndex)
        {
            this.arr = arr;

            if (IsCorrectRange() && IsNotOutOfRange())
            {
                this.lowerIndex = lowerIndex;
                this.higherIndex = higherIndex;
            }
            else
            {
                this.lowerIndex = lowerIndex;
                this.higherIndex = lowerIndex + arr.Length - 1;
            }
        }

        public int this [int index]
        {
            get
            {
                if (IsCorrectIndex(index))
                {
                    return arr[index - lowerIndex];
                }
                else
                {
                    Console.WriteLine("Index is out of the specified range\n");
                    return 0;
                }
            }

            set
            {
                if (IsCorrectIndex(index))
                {
                    arr[index - lowerIndex] = value;
                }
                else
                {
                    Console.WriteLine("Index is out of the specified range\n");
                }
            }
        }

        private bool IsNotOutOfRange()
        {
            int indexRange = higherIndex - lowerIndex + 1;
            int arrayRange = arr.Length;

            return (indexRange <= arrayRange);
        }

        private bool IsCorrectRange()
        {
            return higherIndex > lowerIndex;
        }

        private bool IsCorrectIndex(int index)
        {
            return ((lowerIndex <= index) && (index <= higherIndex));
        }
    }
}
