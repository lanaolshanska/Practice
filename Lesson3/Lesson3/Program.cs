using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<WorkerBase> workers = new List<WorkerBase>();

            WorkerFixedSalary worker1 = new WorkerFixedSalary(1, "Alexandr", 100000000000);
            WorkerHourSalary worker2 = new WorkerHourSalary(2, "Svetlana", 10);
            
            workers.Add(worker1);
            workers.Add(worker2);

            foreach(var emploee in workers)
            {
                emploee.Print();
            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
