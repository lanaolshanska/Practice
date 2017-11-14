using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class WorkerHourSalary : WorkerBase
    {
        private double hourSalary;

        public WorkerHourSalary(int id, string name, double hourSalary) : base(id, name)
        {
            HourSalary = hourSalary;
            Salary = GetMonthSalary();
        }

        public double HourSalary
        {
            get { return hourSalary; }
            set { this.hourSalary = value; }
        }

        public override double GetMonthSalary()
        {
            return this.hourSalary * 8 * 20.8;
        }

        public override void Print()
        {
            Console.WriteLine("\nId: {0}", WorkerId);
            Console.WriteLine("Name: {0}", WorkerName);
            Console.WriteLine("Hourly payment: {0}", HourSalary);
            Console.WriteLine("Monthly salary: {0}\n", Salary);
        }
    }
}
