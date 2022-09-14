using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            //Here ArrayList is inbuilt class
            ArrayList myAl = new ArrayList();
            myAl.Add("Hello");
            myAl.Add("World");
            myAl.Add("!");

            //To print values of ArrayList myAl
            Console.WriteLine("Values:");
            foreach (var item in myAl)
            {
                Console.WriteLine("{0}",item);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Count: {0}", myAl.Count);
            Console.WriteLine("Capacity: {0}", myAl.Capacity);
            Console.ReadKey();

        }
    }
}
