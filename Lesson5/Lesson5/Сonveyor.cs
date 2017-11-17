using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    static class Conveyor
    {
        public enum Actions
        {
            Start = 1,
            Forward,
            Reverse,
            Stop
        }

        static public void MakeAction(Actions action)
        {
            switch ((int)action)
            {
                case 1:
                    Console.WriteLine("Conveyor started");
                    break;
                case 2:
                    Console.WriteLine("Conveyor moved forward");
                    break;
                case 3:
                    Console.WriteLine("Conveyor moved backwards");
                    break;
                case 4:
                    Console.WriteLine("Conveyor stopped");
                    break;
            }
        }
    }
}
