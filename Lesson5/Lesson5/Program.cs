using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 10;
            int value2 = 2;
            double result = 0;

            MathOperations mathOp = new MathOperations();

            Console.WriteLine("Using of enum Operations in clas MathOperations\n");
            foreach(var op in Enum.GetValues(typeof(MathOperations.Operations)))
            {
                result =mathOp.MathOperation(value1, value2, (MathOperations.Operations)op);
                Console.Write("Result of operation {0}: ", op);
                Console.WriteLine(result);
            }

            Conveyor.Actions i;
            
            Console.WriteLine("\nUsing of enum Actions in clas Conveyor\n");
            for (i = Conveyor.Actions.Start; i <= Conveyor.Actions.Stop; i++)
            {
                Conveyor.MakeAction(i);
            }

            Console.WriteLine("\nPress any key to exit the programm");
            Console.ReadKey();
        }
    }
}
