using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    public class MathOperations
    {
        public enum Operations
        {
            Add,
            Subtract,
            Multiply,
            Divide
        }

        public double MathOperation(double value1, double value2, Operations op)
        {
            double result = 0;

            switch (op)
            {
                case Operations.Add:
                    result = value1 + value2;
                    break;
                case Operations.Subtract:
                    result = value1 - value2;
                    break;
                case Operations.Multiply:
                    result = value1 * value2;
                    break;
                case Operations.Divide:
                    result = value1 / value2;
                    break;
            }
            return result;
        }
    }
}
