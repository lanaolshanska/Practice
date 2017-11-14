using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    abstract class WorkerBase
    {
        private int workerId;
        private string workerName;
        protected double salary;

        public WorkerBase(int workerId, string workerName)
        {
            this.workerId = workerId;
            this.workerName = workerName;
        }

        public int WorkerId
        {
            get { return this.workerId; }
            set { this.workerId = value > 0 ? value : -value; }
        }

        public string WorkerName
        {
            get { return this.workerName; }
            set { this.workerName = value; }
        }

        public double Salary
        {
            get { return this.salary; }
            set { this.salary = value > 0 ? value : -value; }
        }

        abstract public double GetMonthSalary();

        abstract public void Print();
    }
}
