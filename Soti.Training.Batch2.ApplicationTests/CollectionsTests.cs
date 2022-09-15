using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Soti.Training.Batch2.Application;
using System.Collections;
using static Application.CollectionsNamespace;


namespace Soti.Training.Batch2.ApplicationTests
{
    [TestClass]
    public class CollectionsTests
    {
        [TestMethod]
        public void ArrayAddTest()
        {
            ArrayListCollection array = new ArrayListCollection();
            array.ArrayListCreation();
            array.ArrayListUpdation(5);
            ArrayList result = new ArrayList() {5};
            Assert.AreEqual(result,array);
            
        }
        [TestMethod]
        public void ArrayReadTest()
        {

        }
        [TestMethod]
        public void ArrayRemoveTest()
        {

        }
        [TestMethod]
        public void QueueUpdationTest()
        {

        }
        [TestMethod]
        public void QueueReadTest()
        {

        }
        [TestMethod]
        public void QueueDeletionTest()
        {

        }


        [TestMethod]
        public void StackUpdationTest()
        {

        }
        [TestMethod]
        public void StackReadTest()
        {

        }
        [TestMethod]
        public void StackDeletionTest()
        {

        }
        [TestMethod]
        public void GQueueUpdationTest()
        {

        }
        [TestMethod]
        public void GQueueReadTest()
        {

        }
        [TestMethod]
        public void GQueueDeletionTest()
        {

        }


        [TestMethod]
        public void GStackUpdationTest()
        {

        }
        [TestMethod]
        public void GStackReadTest()
        {

        }
        [TestMethod]
        public void GStackDeletionTest()
        {

        }

    }
}
