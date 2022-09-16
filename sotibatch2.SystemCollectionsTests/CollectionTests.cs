using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using sotibatch2.Collections;


namespace sotibatch2.SystemCollectionsTests
{
    [TestClass]
    public class CollectionTests
    {
        [TestMethod()]
        public void ArrayListTest()
        {
            Collection obj = new Collection();
            string value = obj.ArrayListCollection();
            Assert.AreEqual("Bill", value);

        }
        [TestMethod()]
        public void StackTest()
        {
            Collection obj1 = new Collection();
            bool value = obj1.StackCollection();
            Assert.AreEqual(true, value);

        }
        [TestMethod()]
        public void QueueTest()
        {
            Collection obj2 = new Collection();
            int value = obj2.QueueCollection();
            Assert.AreEqual(2, value);

        }
    }
}
