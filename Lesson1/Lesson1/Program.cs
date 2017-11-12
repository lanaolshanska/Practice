using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {    
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4 };
            Matrix matrix1 = new Matrix(2, 2, arr1);
            Console.Write("Matrix 1:\n");
            matrix1.Print();

            int[] arr2 = { 5, 6, 7, 8 };
            Matrix matrix2 = new Matrix(2, 2, arr2);
            Console.Write("Matrix 2:\n");
            matrix2.Print();

            Matrix matrixSum = matrix1 + matrix2;
            Console.Write("Sum of matrices:\n");
            matrixSum.Print();

            Matrix matrixSub = matrix1 - matrix2;
            Console.Write("Subtraction of matrices:\n");
            matrixSub.Print();

            Matrix matrixMulti = matrix1 * matrix2;
            Console.Write("Product of matrices:\n");
            matrixMulti.Print();

            matrix1 = matrix1 * 2;
            Console.Write("Multiplication by factor 2:\n");
            matrix1.Print();

            matrix1++;
            Console.Write("Increment operation:\n");
            matrix1.Print();

            matrix1--;
            Console.Write("Decrement operation:\n");
            matrix1.Print();

            Console.WriteLine("Press any key to exit the program...");
            Console.ReadKey();
        }
    }
}
