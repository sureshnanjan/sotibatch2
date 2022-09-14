using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2.Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ArrList arr = new ArrList();
            //arr.ArrayList1();
            //arr.ArrayList2();
            //arr.ArrayList3();
            //HashTable myHash = new HashTable();
            //myHash.Hashtable1();
            //myHash.Hashtable2();
            Square sq1 = new Square(10, 20);
            Square sq2 = new Square(30, 40);
            Square sq3 = sq1 + sq2;
            Console.WriteLine(sq1.getArea());
            Console.WriteLine(sq2.getArea());
            Console.WriteLine(sq3.getArea());

        }
    }
}
