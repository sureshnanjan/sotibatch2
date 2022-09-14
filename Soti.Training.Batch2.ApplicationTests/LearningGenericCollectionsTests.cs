using Microsoft.VisualStudio.TestTools.UnitTesting;
using Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Tests
{
    [TestClass()]
    public class LearningGenericCollectionsTests
    {
        [TestMethod()]
        public void ListExampleTest()
        {

            LearningGenericCollections obj2 = new LearningGenericCollections();
            string value = obj2.ListExample();
            Assert.AreEqual("chinook", value);
        }
        [TestMethod()]
        public void StackExampleTest()
        {

            LearningGenericCollections obj2 = new LearningGenericCollections();
            int value = obj2.GenericStackExample();
            Assert.AreEqual(2, value);
        }  public void qExampleTest()
        {

            LearningGenericCollections obj2 = new LearningGenericCollections();
            int value = obj2.GenericQExample();
            Assert.AreEqual(2, value);
        }
    }
}