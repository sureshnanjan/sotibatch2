using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class LearningGenericCollections
    {
        public LearningGenericCollections()
        {
            ListExample();
            GenericQExample();
            GenericStackExample();
        }

        public string ListExample()
        {
            // Create a list of strings by using a
            // collection initializer.
            var salmons = new List<string> { "chinook", "coho", "pink", "sockeye" };

            // Remove an element from the list by specifying
            // the object.
            salmons.Remove("coho");///delete
            salmons.Add("Added");///Update

            // Iterate through the list.read
            foreach (var salmon in salmons)
            {
                Console.Write(salmon + " ");
            }
            return salmons[0];
        }

        public int GenericStackExample()
        {
            Stack<int> myStack = new Stack<int>();///creation



            myStack.Push(1);///Updation
            myStack.Push(2);
            myStack.Push(3);



            foreach (var item in myStack)
                Console.Write(item + ","); ///Read from stack



            myStack.Pop(); ///Delete from stack



            return myStack.Peek();



        }
        public int GenericQExample()
        {
            Queue<int> callerIds = new Queue<int>(); //create q
            callerIds.Enqueue(1);///update q
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);



            foreach (var id in callerIds)///read q
                Console.Write(id);



            callerIds.Dequeue();///delete q
            return callerIds.Peek();

        }

    }
}
