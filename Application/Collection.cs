using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Collection
    {
        public ArrayList array1;

        public void ArrayListCreation(int a)
        {
            array1 = new ArrayList();

        }
        public void ArrayListUpdation(int a)
        {
            array1.Add(a);
        }
        public void ArrayListRead()
        {
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        }
        public void ArrayListDeletion(int a)
        {
            array1.Remove(a);
        }
    }

    public class QueueCollection
    {
        Queue array1;

        public void QueueCreation(int a)
        {
            array1 = new Queue(a);
        }
        public void QueueUpdation(int a)
        {
            array1.Enqueue(a);
        }
        public void QueueRead()
        {
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        }
        public void QueuetDeletion()
        {
            array1.Dequeue();
        }


    }


    public class StackCollection
    {
        Stack array1;

        public void StackCreation(int a)
        {
            array1 = new Stack(a);
        }
        public void StackUpdation(int a)
        {
            array1.Push(a);
        }
        public void StackeRead()
        {
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        }
        public void StackDeletion()
        {
            array1.Pop();
        }


    }

    public class GenericQueue<type>
    {
        Queue<type> array1;
        public void GenericQueueCreation()
        {
            array1 = new Queue<type>();
        }
        public void GenericQueueUpdation(type a)
        {
            array1.Enqueue(a);
        }
        public void GenericQueueRead()
        {
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        }
        public void GenericQueuetDeletion()
        {
            array1.Dequeue();
        }
    }

    public class GenericStackCollection<type>
    {
        Stack<int> array1;

        public void GenericStackCreation(int a)
        {
            array1 = new Stack<int>(a);
        }
        public void GenericStackUpdation(int a)
        {
            array1.Push(a);
        }
        public void GenericStackeRead()
        {
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        }
        public void GenericStackDeletion()
        {
            array1.Pop();
        }


    }

    public class GenericList<type>
    {
        List<type> array1;
        public void GenericListCreation()
        {
            array1 = new List<type>();
        }
        public void GenericListUpdation(type a)
        {
            array1.Add(a);
        }
        public void GenericListRead()
        {
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        }
        public void GenericListDeletion(type a)
        {
            array1.Remove(a);
        }
    }
}