using Microsoft.VisualStudio.TestTools.UnitTesting;
using Soti.Training.Batch2.Models;
using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionsTests
{
    [TestClass]
    public class CollectionTests1
    {
        [TestMethod]
        public void ArrayListTest()
        {
            ArrayList array = new ArrayList();
            array.Add(1);
            array.Add(2);
            array.Add(3);
            ArrayList result1 = new ArrayList() { 1, 2, 3 };
            CollectionAssert.AreEqual(array, result1);
            array.Remove(2);
            ArrayList result2 = new ArrayList() { 1, 3 };
            CollectionAssert.AreEqual(array, result2);
        }

        [TestMethod]
        public void QueTest()
        {
            Queue array1 = new Queue();
            array1.Enqueue(1);
            array1.Enqueue(2);
            array1.Enqueue(3);
            array1.Enqueue(4);

            Queue result1 = new Queue() {
            };
           
            array1.Dequeue();
            array1.Dequeue();
            array1.Dequeue();
            array1.Dequeue();

            CollectionAssert.AreEqual(array1, result1);
        }

        [TestMethod]
        public void StackTest()
        {


            Stack array1 = new Stack();
            array1.Push(1);
            array1.Push(2);
            array1.Push(3);
            array1.Push(4);

            Queue result1 = new Queue()
            {
            };

            array1.Pop();
            array1.Pop();
            array1.Pop();
            array1.Pop();

            CollectionAssert.AreEqual(array1, result1);
        }

        [TestClass]

        public class GenericCollectionTest
        {



            [TestMethod]

            public void ListTest()
            {


                List<Part> parts = new List<Part>();

                // Add parts to the list.
                parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
                parts.Add(new Part() { PartName = "chain ring", PartId = 1334 });
                parts.Add(new Part() { PartName = "regular seat", PartId = 1434 });
                parts.Add(new Part() { PartName = "banana seat", PartId = 1444 });
                parts.Add(new Part() { PartName = "cassette", PartId = 1534 });
                parts.Add(new Part() { PartName = "shift lever", PartId = 1634 });

                parts.Remove(new Part() { PartId = 1534, PartName = "cogs" });


                List<Part> partsResult = new List<Part>();
                partsResult.Add(new Part() { PartName = "crank arm", PartId = 1234 });
                partsResult.Add(new Part() { PartName = "chain ring", PartId = 1334 });
                partsResult.Add(new Part() { PartName = "regular seat", PartId = 1434 });
                partsResult.Add(new Part() { PartName = "banana seat", PartId = 1444 });

                partsResult.Add(new Part() { PartName = "shift lever", PartId = 1634 });
                CollectionAssert.AreEqual(parts, partsResult);

            }
            [TestMethod]
            public void GenerticQueueTest()
            {


                Queue<string> numbers = new Queue<string>();
                numbers.Enqueue("one");
                numbers.Enqueue("two");
                numbers.Enqueue("three");
                numbers.Enqueue("four");
                numbers.Enqueue("five");

                numbers.Dequeue();


                Queue<string> numbersResult = new Queue<string>();

                numbersResult.Enqueue("two");
                numbersResult.Enqueue("three");
                numbersResult.Enqueue("four");
                numbersResult.Enqueue("five");
                CollectionAssert.AreEqual(numbers, numbersResult);

            }
            [TestMethod]
            public void GenerticStackTest()
            {


                Stack<string> numbersStack = new Stack<string>();
                numbersStack.Push("one");
                numbersStack.Push("two");
                numbersStack.Push("three");
                numbersStack.Push("four");
                numbersStack.Push("five");

                numbersStack.Pop();


                Stack<string> numbersStackRes = new Stack<string>();
                numbersStackRes.Push("one");
                numbersStackRes.Push("two");
                numbersStackRes.Push("three");
                numbersStackRes.Push("four");
               
                CollectionAssert.AreEqual(numbersStack, numbersStackRes);

            }



        }
    }
}
