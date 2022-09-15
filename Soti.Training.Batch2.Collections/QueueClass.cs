using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2.Collections
{
    public class QueueClass
    {
        public void Queue1()
        {
            Queue myQ = new Queue();
            myQ.Enqueue("reuben");
            myQ.Enqueue("joseph");
            myQ.Enqueue("philip");
            foreach (var item in myQ)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(myQ.Peek().ToString());

        }
    }
}