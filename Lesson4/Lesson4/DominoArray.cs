using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class DominoArray
    {
        public DominoStruct[] dominoesArray { get; private set; }
        public int length { get; private set; }

        public DominoArray(DominoStruct[] dominoesArray)
        {
            this.length = dominoesArray.Length;
            this.dominoesArray = dominoesArray;
        }

        public void Print()
        {
            for (int i = 0; i < length; i++)
            {
                dominoesArray[i].Print();
            }
        }

        public bool IsGameCorrect()
        {
            bool answer = true;

            if (!IsDominoCorrect())
            {
                Console.WriteLine("Some dominoes are incorrect");
                answer = false;
            }

            if (IsDominoesSequenceOk())
            {
                Console.WriteLine("Game is Ok");
            }
            else
            {
                Console.WriteLine("Dominoes sequence is incorrect");
                answer = false;
            }

            return answer;
        }

        private bool IsDominoesSequenceOk()
        {
            for (int i = 0; i < length - 2; i++)
            {
                if (!IsNextTrue(dominoesArray[i], ref dominoesArray[i + 1]))
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsNextTrue(DominoStruct domino1, ref DominoStruct domino2)
        {
            if (domino1.y != domino2.x)
            {
                domino2.Swap();
                if (domino1.y != domino2.x)
                {
                    return false;
                }
            }
            return true;
        }

        private bool IsDominoCorrect()
        {
            for (int i = 0; i < length; i++)
            {
                if (!dominoesArray[i].IsCorrect())
                {
                    return false;
                }
            }
            return true;
        }
    }
}
