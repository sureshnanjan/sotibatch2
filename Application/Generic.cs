using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Generic
    {
        public int List()
        {
            // Creating a list containin names

            var names = new List<string>() { "Mack", "Daisy", "Ward" };

            // Reading list
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(" ");
            //Updating list
            names[1] = "Fitz";
            foreach (var item in names)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine(" ");
            // Deleting from list
            names.RemoveAt(0);
            foreach (var item in names)
            {
                Console.WriteLine(item);

            }

            return names.Count;
        }

        public bool GenericStack()
        {
            Stack <int>myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            //Upating

            myStack.Push(4);

            //Read

            foreach (var item in myStack)
                Console.Write(item + ","); //output=4,3,2,1(LIFO)

            Console.WriteLine(" ");

            //Delete

            myStack.Pop();
            foreach (var item in myStack)
            {
                Console.WriteLine(item);//3,2,1

            }

            return myStack.Contains(2);//True
        }
        public int Queue()
        {
            //create queue
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);

            //Updating Queue

            callerIds.Enqueue(4);

            //Read

            foreach (var id in callerIds)
            {
                Console.Write(id);//1,2,3,4
            }
            Console.WriteLine(" ");

            //Delete queue

            callerIds.Dequeue();
            foreach (var item in callerIds)
            {
                Console.WriteLine(item);//2,3,4
            }
            return (int)callerIds.Peek();//Returns first item without removing:2
        }

    }
}
