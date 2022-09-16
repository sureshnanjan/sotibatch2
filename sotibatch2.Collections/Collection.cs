using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sotibatch2.Collections
{
    public class Collection
    {
        public Collection()
        {

            ArrayListCollection();
            StackCollection();
            QueueCollection();

        }

        public string ArrayListCollection()
        {
            ArrayList arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);
            int firstElement = (int)arlist1[0];
            arlist1.RemoveAt(4);
            Console.WriteLine("ArrayList 1 Elements");

            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);
            return (string)arlist1[1];

        }
        public bool StackCollection()
        {
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");
            

            foreach (var item in myStack)
                Console.Write(item + ",");
            Console.Write("\n");
            myStack.Pop();

            foreach (var item in myStack)
                Console.Write(item + ",");
            return myStack.Contains(1);

        }
        public int QueueCollection()
        {
            Queue callerIds = new Queue();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.Write(id);
            Console.WriteLine("\n");
            Console.WriteLine(callerIds.Dequeue());

            foreach (var id in callerIds)
                Console.Write(id);
            return (int)callerIds.Peek();

        }
    }
}
