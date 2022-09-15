using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    //Implementing Generic Queue Collection
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

    //Implementing Generic Stack Collection
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

    //Implementing Generic Hash set Collection
    public class GenericHashCollection<type>
    {
        HashSet<int> array1;
        public void GenericHashCreation(int a)
        {
            array1 = new HashSet<int>(a);
        }
        public void GenericHashUpdation(int a)
        {
            array1.Add(a);
        }
        public void GenericHashRead()
        {
            foreach (var item in array1)
            {
                Console.WriteLine(item);
            }
        }
        public void GenericHashDeletion(int a)
        {
            array1.Remove(a);
        }
    }

    //Implementing Generic Sorted list Collection
    public class GenericSortedListCollection
    {
        SortedList<string, string> array1;
        public void GenericSortedListCreation(int a)
        {
            array1 = new SortedList<string, string>(a);
        }
        public void GenericSortedListUpdation(string key, string value)
        {
            array1.Add(key, value);
        }
        public void GenericSortedListRead()
        {
            foreach (KeyValuePair<string, string> item in array1)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }
        }
        public void GenericSortedListDeletion(string key)
        {
            array1.Remove(key);
        }
    }
}
