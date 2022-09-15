using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace Application
{
    public class ArrayListCollections
    {
        public ArrayList myArray;
        //creation 
        public void createArray()
        {
            myArray = new ArrayList();

        }

        //Updation
        public void updateArray(int p0)
        {
            myArray.Add(p0);
        }

        //deletion
        public void deleteElement(ArrayList array, int p0)
        {
            myArray.Remove(p0);
        }

        //read
        public void readArray()
        {
            foreach (var item in myArray)
            {
                Console.WriteLine(item);

            }
        }
    }

    public class QueueCollection
    {
        public Queue myQ;

        //create
        public void createQueue()
        {
            myQ = new Queue();
        }

        //update
        public void updateQueue(int p0)
        {
            myQ.Enqueue(p0);
        }

        //read
        public void readQueue()
        {
            foreach (var item in myQ)
            {
                Console.WriteLine(item);
            }
        }

        //deletion
        public void deleteQueueElement()
        {
            myQ.Dequeue();
        }
    }

    public class StackCollection
    {
        Stack myStack;
        //create
        public void createStack()
        {
            Stack myStack = new Stack();
        }

        //update
        public void updateStack(int p0)
        {
            myStack.Push(p0);
        }

        //read
        public void readStack()
        {
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }
        }

        //delete
        public void deleteStackItem()
        {
            myStack.Pop();
        }
    }

    //Generic Collections
    public class GenericQueue<type>
    {
        Queue<type> array1;
        //create
        public void GenericQueueCreation()
        {
            array1 = new Queue<type>();
        }
        //update
        public void GenericQueueUpdation(type a)
        {
            array1.Enqueue(a);
        }
        //read
        public void GenericQueueRead()
        {
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        }
        //delete
        public void GenericQueuetDeletion()
        {
            array1.Dequeue();
        }
    }



    public class GenericStackCollection<type>
    {
        Stack<int> array1;


        //create
        public void GenericStackCreation()
        {
            array1 = new Stack<int>();
        }

        //update
        public void GenericStackUpdation(int a)
        {
            array1.Push(a);
        }

        //read
        public void GenericStackRead()
        {
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        }

        //delete
        public void GenericStackDeletion()
        {
            array1.Pop();
        }

        public class ListCollection<type>
        {
            List<int> myList;
            //create
            public void createGenericList()
            {
                myList = new List<int>();
            }

            //updateList
            public void updateGenericList(int p0)
            {
                myList.Add(p0);
            }

            //read
            public void readGenericList()
            {
                foreach (var item in myList)
                {
                    Console.WriteLine(item);
                }
            }

            //delete
            public void deleteGenericListItem(int p0)
            {
                myList.Remove(p0);
            }


        }

        
    }
}
