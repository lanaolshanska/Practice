using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class WorkerFixedSalary : WorkerBase
    {
        public WorkerFixedSalary(int id, string name, double salary) : base(id, name) {
            Salary = salary;
        }

        public override double GetMonthSalary()
        {
            return Salary;
        }

        public override void Print()
        {
            Console.WriteLine("\nId: {0}", WorkerId);
            Console.WriteLine("Name: {0}", WorkerName);
            Console.WriteLine("Monthly salary: {0}\n", Salary);
        }
    }
}
