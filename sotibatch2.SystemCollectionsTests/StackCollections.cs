using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace sotibatch2.SystemCollectionsTests
{
    [TestClass]
    public class StackCollections
    {
        [TestMethod]
        public void stack()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("World");
            myStack.Push("!");

            foreach (var item in myStack)
                Console.Write(item + ",");
                Console.Write("\n");
            myStack.Pop();

            foreach (var item in myStack)
                Console.Write(item + ",");


        }
    }
}
