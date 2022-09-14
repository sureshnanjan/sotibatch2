using System;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class LearningCollections
    {
        public LearningCollections()
        {
        
            ArrayListExample();
            StackExample();
            QExample();

        }

         
        public string ArrayListExample()
        {
            ArrayList arList = new ArrayList()
                {
                    1,
                    null,
                    "Bill",
                    300,
                    " ",
                    4.5f,
                    300,
                };///Creation

            arList.Remove(null); ///Deletion
            arList.Insert(1, "Second Item");//updation

            foreach (var val in arList)
                Console.WriteLine(val);///read
            return (string)arList[1];
        }
        public bool StackExample()
        {
            // Creating a stack



            Stack myStack = new Stack();
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
        public int QExample()
        {
            //create queue
            Queue callerIds = new Queue();
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
