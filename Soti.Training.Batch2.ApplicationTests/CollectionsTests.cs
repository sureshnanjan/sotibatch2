using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Application;
using System.Collections;
namespace Soti.Training.Batch2.ApplicationTests
{
    [TestClass]
    public class CollectionsTests
    {
        [TestMethod]
        public void arraylistCreation()
        {
            ArrayListCollections testInstance = new ArrayListCollections();
            testInstance.createArray();
            //Assert.IsInstanceOfType(ArrayList, typeof(testInstance));

        }
    }
}
