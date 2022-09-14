using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Soti.Training.Batch2.Application;
using Application;
using System.Collections;
using System.Collections.Generic;

namespace Soti.Training.Batch2.ApplicationTests
{
    [TestClass]
    public class CollectionTests
    {
        [TestMethod]
        public void ArrayListCreation()
        {

            Collection array = new Collection();
            array.ArrayListCreation(5);
            ArrayList result = new ArrayList() { 5 };
            Assert.ReferenceEquals(result, array);

        }
        [TestMethod]
        public void ArrayListUpdation()
        {

            Collection array = new Collection();
            array.ArrayListCreation(5);
            array.ArrayListUpdation(6);
            ArrayList result = new ArrayList() { 5, 6 };
            Assert.ReferenceEquals(result, array);

        }
        [TestMethod]
        public void ArrayListDeletion()
        {

            Collection array = new Collection();
            array.ArrayListCreation(5);
            array.ArrayListUpdation(6);
            array.ArrayListUpdation(8);
            array.ArrayListDeletion(6);
            ArrayList result = new ArrayList() { 5, 8 };
            Assert.ReferenceEquals(result, array);

        }

        [TestMethod]
        public void QueueCreation()
        {

            QueueCollection queue = new QueueCollection();
            queue.QueueCreation(2);
            Queue result = new Queue(2);
            Assert.ReferenceEquals(result, queue);

        }

        [TestMethod]
        public void QueueUpdation()
        {

            QueueCollection queue = new QueueCollection();
            queue.QueueCreation(2);
            queue.QueueUpdation(4);
            Queue result = new Queue(2, 4);
            Assert.ReferenceEquals(result, queue);

        }

        [TestMethod]
        public void QueueDeletion()
        {

            QueueCollection queue = new QueueCollection();
            queue.QueueCreation(2);
            queue.QueueUpdation(4);
            queue.QueueUpdation(9);
            queue.QueuetDeletion();
            Queue result = new Queue(4, 9);
            Assert.ReferenceEquals(result, queue);

        }

        [TestMethod]
        public void StackCreation()
        {

            StackCollection stack = new StackCollection();
            stack.StackCreation(7);
            Stack result = new Stack(7);
            Assert.ReferenceEquals(result, stack);

        }

        [TestMethod]
        public void StackUpdation()
        {

            StackCollection stack = new StackCollection();
            stack.StackCreation(7);
            stack.StackUpdation(8);
            Stack result = new Stack(7);
            result.Push(8);
            Assert.ReferenceEquals(result, stack);

        }

        [TestMethod]
        public void StackDeletion()
        {

            StackCollection stack = new StackCollection();
            stack.StackCreation(7);
            stack.StackUpdation(8);
            stack.StackUpdation(80);
            stack.StackDeletion();
            Stack result = new Stack(7);
            result.Push(8);
            result.Push(80);
            result.Pop();
            Assert.ReferenceEquals(result, stack);

        }






        [TestMethod]
        public void GenericQueueCreation()
        {

            GenericQueue<string> queue = new GenericQueue<string>();
            queue.GenericQueueCreation();

            Queue result = new Queue();
            Assert.ReferenceEquals(result, queue);

        }

        [TestMethod]
        public void GenericQueueUpdation()
        {

            GenericQueue<string> queue = new GenericQueue<string>();
            queue.GenericQueueCreation();
            queue.GenericQueueUpdation("anjana");
            Queue<string> result = new Queue<string>();
            result.Enqueue("anjana");
            Assert.ReferenceEquals(result, queue);

        }

        [TestMethod]
        public void GenericQueueDeletion()
        {
            GenericQueue<string> queue = new GenericQueue<string>();
            queue.GenericQueueCreation();
            queue.GenericQueueUpdation("anjana");
            queue.GenericQueuetDeletion();
            Queue<string> result = new Queue<string>();

            Assert.ReferenceEquals(result, queue);


        }


        [TestMethod]
        public void GenericStackCreation()
        {

            GenericStackCollection<int> stack = new GenericStackCollection<int>();
            stack.GenericStackCreation(7);
            Stack result = new Stack(7);
            Assert.ReferenceEquals(result, stack);

        }

        [TestMethod]
        public void GenericStackUpdation()
        {

            GenericStackCollection<int> stack = new GenericStackCollection<int>();
            stack.GenericStackCreation(7);
            stack.GenericStackUpdation(8);
            Stack result = new Stack(7);
            result.Push(8);
            Assert.ReferenceEquals(result, stack);

        }

        [TestMethod]
        public void GenericStackDeletion()
        {

            GenericStackCollection<int> stack = new GenericStackCollection<int>();
            stack.GenericStackCreation(7);
            stack.GenericStackUpdation(8);
            stack.GenericStackUpdation(80);
            stack.GenericStackDeletion();
            Stack result = new Stack(7);
            result.Push(8);
            result.Push(80);
            result.Pop();
            Assert.ReferenceEquals(result, stack);

        }


        [TestMethod]
        public void ListCreation()
        {

            GenericList<int> array = new GenericList<int>();
            array.GenericListCreation();
            List<int> result = new List<int>();
            Assert.ReferenceEquals(result, array);

        }
        [TestMethod]
        public void ListUpdation()
        {

            GenericList<int> array = new GenericList<int>();
            array.GenericListCreation();
            array.GenericListUpdation(6);
            List<int> result = new List<int>(6);
            result.Add(6);
            Assert.ReferenceEquals(result, array);

        }
        [TestMethod]
        public void ListDeletion()
        {

            GenericList<int> array = new GenericList<int>();
            array.GenericListCreation();
            array.GenericListUpdation(6);
            array.GenericListUpdation(69);
            array.GenericListDeletion(6);
            List<int> result = new List<int>(69);

            Assert.ReferenceEquals(result, array);


        }
    }
}