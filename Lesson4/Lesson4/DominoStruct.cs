using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    struct DominoStruct
    {
        public int x;
        public int y;

        public DominoStruct (int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Swap()
        {
            int tmp = this.x;
            this.x = y;
            this.y = tmp;
        }
        
        public void Print()
        {
            Console.Write("[{0}|{1}] ", this.x, this.y);
        }

        public bool IsCorrect()
        {
            return ((0 <= this.x && this.x <= 6) &&
                    (0 <= this.y && this.y <= 6));
        }
    }
}
