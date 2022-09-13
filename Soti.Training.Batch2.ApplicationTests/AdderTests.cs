using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Soti.Training.Batch2.Application;

namespace Soti.Training.Batch2.ApplicationTests
{
    [TestClass]
    public class AdderTests
    {
        public void SimpleMethod() {
            Adder simpleInstance = new Adder(10,20);
            simpleInstance.OldMethodToAdd(10, 20);
        }
        
        [TestMethod]
        public void Adding4and3is7()
        {
            Adder testInstance = new Adder(4, 3);
            int result = testInstance.Add();
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void Adding100and3is104()
        {
            Adder testInstance = new Adder(100, 3);
            int result = testInstance.Add();
            Assert.AreEqual(103, result);
        }

        [TestMethod]
        public void AddingNegative100and3isCorrect()
        {
            Adder testInstance = new Adder(-100, -3);
            int result = testInstance.Add();
            Assert.AreEqual(-103, result);
        }
    }
}
