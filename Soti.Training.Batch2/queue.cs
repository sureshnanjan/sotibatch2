using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2
{
    public  class queue
    {
        public void queue1()
        {
            Queue myQueue = new Queue();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue("dennis");
            Console.WriteLine($"no of elements in queue{myQueue.Count}");
            foreach(var ele in myQueue)
            {
                Console.WriteLine(ele);
            }

        }
    }
}
