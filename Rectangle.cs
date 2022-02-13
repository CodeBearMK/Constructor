using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    internal class Rectangle
    {

        public int Length { get; set; }
        public int Wide { get; set; }

        public Rectangle()
        {
            Console.WriteLine("已進入 Default Constructor...");
        }
        public Rectangle(int L, int W)
        {
            Length = L;
            Wide = W;
        }
        public int GetArea(int L, int W)
        {
            return Length * Wide;
        }
    }
}
