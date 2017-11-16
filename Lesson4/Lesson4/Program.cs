using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            DominoStruct[] dominoes =
            {
                new DominoStruct(2,1),
                new DominoStruct(1,3),
                new DominoStruct(6,3),
                new DominoStruct(6,4)
            };

            DominoArray dominoGame = new DominoArray(dominoes);

            dominoGame.IsGameCorrect();
            dominoGame.Print();

            Console.WriteLine("\n\nPress any key to exit the program.");
            Console.ReadKey();
        }
    }
}
