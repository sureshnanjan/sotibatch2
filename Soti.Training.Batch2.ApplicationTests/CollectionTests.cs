using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Soti.Training.Batch2.Application;
using Application;

namespace Soti.Training.Batch2.ApplicationTests
{
    [TestClass]
    public class CollectionTests
    {
        [TestMethod]
        public void ListTest()
        {
            Generic Creation = new Generic();
            int value = Creation.List();
            Assert.AreEqual(2, value);


        }

        [TestMethod]
        public void ArrayListTest()
        {
            Collection Creation = new Collection();
            string name = Creation.ArrayList();
            Assert.AreEqual("Second Item", name);


        }

        [TestMethod]
        public void StackTest()
        {
            Collection Creation = new Collection();
            bool number = Creation.Stack();
            Assert.AreEqual(true, number);


        }

        [TestMethod]
        public void QueueTest()
        {
            Collection Creation = new Collection();
            int number = Creation.Queue();
            Assert.AreEqual(2, number);


        }

        [TestMethod]
        public void GenericStackTest()
        {
            Generic Creation = new Generic();
            bool number = Creation.GenericStack();
            Assert.AreEqual(true, number);

        }
        [TestMethod]
        public void GenericQueueTest()
        {
            Generic Creation = new Generic();
            int number = Creation.Queue();
            Assert.AreEqual(2, number);

        }
    }
}