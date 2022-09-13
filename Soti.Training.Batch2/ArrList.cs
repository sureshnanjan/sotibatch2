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
            foreach (Object obj in myAL)
                Console.Write("   {0}", obj);
            Console.WriteLine();


        }
        

    }
}
