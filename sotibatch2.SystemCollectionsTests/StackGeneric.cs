using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace sotibatch2.SystemCollectionsTests
{
    [TestClass]
    public class StackGeneric
    {
        [TestMethod]
        public void Stack()
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            

            foreach (var item in myStack)
                Console.Write(item + ",");
            Console.WriteLine("\n");

            Console.WriteLine(myStack.Pop());

            foreach (var item in myStack)
                Console.Write(item + ",");

        }
    }
}
