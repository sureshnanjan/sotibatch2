using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ArrayListMethod(); //Arraylist implementation
            QueueMethod();  // Queue implementation
            StackMethod();
            SortedListMethod();
            Console.ReadKey();

        }
        public static void ArrayListMethod()
        {
            //Here ArrayList is inbuilt class
            ArrayList myAl = new ArrayList();
            myAl.Add("Hello");
            myAl.Add("World");
            myAl.Add("!");

            //To print values of ArrayList myAl
            Console.WriteLine("ArrayList\n\nValues:");
            foreach (var item in myAl)
            {
                Console.WriteLine("{0}", item);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Count: {0}", myAl.Count);
            Console.WriteLine("Capacity: {0}", myAl.Capacity);
        }
        public static void QueueMethod()
        {
            Queue myQ = new Queue();
            myQ.Enqueue("Hello");
            myQ.Enqueue("World");
            myQ.Enqueue("!");
          

            // Displays the properties and values of the Queue.
            Console.WriteLine("Queue\n\n");
            Console.WriteLine("\tCount:    {0}", myQ.Count);
            Console.Write("\tValues:");
            PrintQueueValues(myQ);
        }

        public static void PrintQueueValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
        public static void StackMethod()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            // Displays the properties and values of the Stack.
            Console.WriteLine("Stack\n\n");
            Console.WriteLine("\tCount:    {0}", myStack.Count);
            Console.Write("\tValues:");
            PrintStackValues(myStack);
        }

        public static void PrintStackValues(IEnumerable myCollection)
        {
            foreach (Object obj in myCollection)
                Console.Write("    {0}", obj);
            Console.WriteLine();
        }
        public static void SortedListMethod()
        {
            SortedList mySL = new SortedList();
            mySL.Add("Third", "!");
            mySL.Add("Second", "World");
            mySL.Add("First", "Hello");

            // Displays the properties and values of the SortedList.
            Console.WriteLine("Sorted List\n\n");
            Console.WriteLine("  Count:    {0}", mySL.Count);
            Console.WriteLine("  Capacity: {0}", mySL.Capacity);
            Console.WriteLine("  Keys and Values:");
            PrintKeysAndValues(mySL);
    }

    public static void PrintKeysAndValues(SortedList myList)
    {
        Console.WriteLine("\t-KEY-\t-VALUE-");
        for (int i = 0; i < myList.Count; i++)
        {
            Console.WriteLine("\t{0}:\t{1}", myList.GetKey(i), myList.GetByIndex(i));
        }
        Console.WriteLine();
    }
}
}
