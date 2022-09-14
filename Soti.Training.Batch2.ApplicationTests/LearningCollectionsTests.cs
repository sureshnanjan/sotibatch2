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
    public class LearningCollectionsTests
    {
        [TestMethod()]
        public void StackListExampleTest()
        {
            LearningCollections obj = new LearningCollections();
            bool value = obj.StackExample();
            Assert.AreEqual(true, value);

        } 
        [TestMethod()]
        public void QExampleTest()
        {
            LearningCollections obj1 = new LearningCollections();
            int value = obj1.QExample();
            Assert.AreEqual(2, value);

        }
        [TestMethod()]
        public void ArrayListExampleTest()
        {
            LearningCollections obj2 = new LearningCollections();
            string value = obj2.ArrayListExample();
            Assert.AreEqual("Second Item", value);

        }
    }
}