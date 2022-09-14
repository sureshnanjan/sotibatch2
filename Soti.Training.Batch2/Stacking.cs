using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2
{
    public class Stacking
    {
        public void stack1()
        {


            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("dennis");
            foreach(var ele in myStack)
            {
                Console.WriteLine(ele);
            }

        }

    }
}
