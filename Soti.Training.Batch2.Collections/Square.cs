using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2.Collections
{
    public class Square
    {
        int length, breadth;
        public Square(int length, int breadth)
        {
            this.length = length;
            this.breadth = breadth;
        }
        public int getArea()
        {
            return length * breadth;
        }
        public static Square operator +(Square b, Square c) 
        { 
            return new Square(b.length + c.length, b.breadth + c.breadth);
        }

   
    }
}
