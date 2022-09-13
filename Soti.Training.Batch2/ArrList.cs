using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2
{
    public class ArrList
    {
        public void list()
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("Dennis");
            myAL.Add("Vadakkedam");
            myAL.Add("SOTI");
            myAL.AddRange(new ArrayList() { "range", "array" });
            myAL.Remove("range");
            
            foreach (Object obj in myAL)
                Console.Write("   {0}", obj);
            Console.WriteLine();
            //ArrayList myArray = new ArrayList();
            //myArray.Add(1);
            //myArray.Add(1);
            //myArray.Add(1);
            //foreach (Object obj in myArray)
            //    Console.Write("   {0}", obj);
            //Console.WriteLine();







        }
        public void list2()
        {
            ArrayList myArray = new ArrayList();
            myArray.Add(1);
            myArray.Add(1);
            myArray.Add(1);
            foreach (Object obj in myArray)
                Console.Write("   {0}", obj);
            Console.WriteLine();
            ArrayList myReadOnlyAL = ArrayList.ReadOnly(myArray);
            Console.WriteLine("myReadOnlyAL is {0}.", myReadOnlyAL.IsReadOnly ? "read-only" : "writable");
            foreach (int myInt in myReadOnlyAL)
                Console.WriteLine("   {0}", myInt);
            myReadOnlyAL.Add(1);

        }



    }
}
