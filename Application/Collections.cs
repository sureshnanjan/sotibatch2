using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    //Implementing Arraylist Collection
    public class ArrayListCollection 
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

    //Implementing Queue Collection
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

    //Implementing Stack Collection
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

    //Implementing Hash Table Collection
    public class HashTableCollection
    {
        Hashtable array1;
        public void HashTableCreation(int a)
        {
            array1 = new Hashtable(a);
        }
        public void HashTableUpdation(string key, string value)
        {
            array1.Add(key, value);
        }
        public void HashTableRead()
        {
            foreach (DictionaryEntry item in array1)
            {
                Console.WriteLine("Key = {0}, Value = {1}", item.Key, item.Value);
            }
        }
        public void HashTableDeletion(string key)
        {
            array1.Remove(key);
        }
    }


}


