using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Soti.Training.Batch2.CollectionTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ArrayListTest1()
        {
            ArrayList array = new ArrayList();
            array.Add("Reuben");
            array.Add("Philip");
            array.Add("Joseph");
            Assert.AreEqual(3, array.Count);
        }
        [TestMethod]
        public void ArrayListTest2()
        {
            ArrayList array = new ArrayList();
            array.Add("Reuben");
            array.Add("Philip");
            array.Add("Joseph");
            string sent = string.Empty;
            foreach(var item in array)
            {
                sent = sent + " " + item.ToString();
            }
            Assert.AreEqual("Reuben Philip Joseph", sent.Trim());


        }
        [TestMethod]
        public void ArrayListTest3()
        {
            ArrayList array = new ArrayList();
            array.Add("Reuben");
            array.Add("Philip");
            array.Add("Joseph");
            array.Sort();
            string sent = string.Empty;
            foreach (var item in array)
            {
                sent = sent + " " + item.ToString();
            }
            Assert.AreEqual("Joseph Philip Reuben", sent.Trim());

        }

    }
}