using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Matrix
    {
        int rows { get; set; }
        int columns { get; set; }
        int[,] arr { get; set; }

        public Matrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
            this.arr = new int[rows, columns];
        }

        public Matrix(int rows, int columns, int[]arr)
        {
            this.rows = rows;
            this.columns = columns;
            this.arr = new int[rows, columns];

            int k = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    this.arr[i, j] = arr[k++];
                }
            }
        }

        public void CreateArray()
        {
            Random rnd = new Random();

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    arr[i, j] = rnd.Next(-101, 101);
                }
            }
        }

        public void CreateArray(int[] arr)
        {
            int k = 0;

            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < columns; j++)
                {
                    this.arr[i, j] = arr[k++];
                }
            }
        }

        public void Print()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            if ((matrix1.rows == matrix2.rows) &&
                (matrix1.columns == matrix2.columns))
            {
                Matrix matrixSum = new Matrix(matrix1.rows, matrix1.columns);
                for(int i = 0; i < matrixSum.rows; i++)
                {
                    for(int j = 0; j < matrixSum.columns; j++)
                    {
                        matrixSum.arr[i, j] = matrix1.arr[i, j] + matrix2.arr[i, j];
                    }
                }
                return matrixSum;
            }
            else
            {
                Console.WriteLine("Matrices have different number of rows and columns");
                return matrix1;
            }
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            if ((matrix1.rows == matrix2.rows) && 
                (matrix1.columns == matrix2.columns))
            {
                Matrix matrixSub = new Matrix(matrix1.rows, matrix1.columns);
                for (int i = 0; i < matrixSub.rows; i++)
                {
                    for (int j = 0; j < matrixSub.columns; j++)
                    {
                        matrixSub.arr[i, j] = matrix1.arr[i, j] - matrix2.arr[i, j];
                    }
                }
                return matrixSub;
            }
            else
            {
                Console.WriteLine("Matrices have different number of rows and columns");
                return matrix1;
            }
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.columns == matrix2.rows)
            {
                Matrix matrixMulti = new Matrix(matrix1.rows, matrix2.columns);
                for (int i = 0; i < matrixMulti.rows; i++)
                {
                    for (int j = 0; j < matrixMulti.columns; j++)
                    {
                        for (int k = 0; k < matrix2.rows; k++)
                        {
                            matrixMulti.arr[i, j] += matrix1.arr[i, k] * matrix2.arr[k, j];
                        }
                    }
                }
                return matrixMulti;
            }
            else
            {
                Console.WriteLine("For multiplying the matrix, the number of columns of the first matrix" +
                                  "must be equal the number of rows of the second matrix");
                return matrix1;
            }
        }

        public static Matrix operator *(Matrix matrix, int factor)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.columns; j++)
                {
                    matrix.arr[i, j] = matrix.arr[i, j] * factor;
                }
            }
            return matrix;
        }

        public static Matrix operator ++(Matrix matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.columns; j++)
                {
                    matrix.arr[i, j]++;
                }
            }
            return matrix;
        }

        public static Matrix operator --(Matrix matrix)
        {
            for (int i = 0; i < matrix.rows; i++)
            {
                for (int j = 0; j < matrix.columns; j++)
                {
                    matrix.arr[i, j]--;
                }
            }
            return matrix;
        }
    }
}
