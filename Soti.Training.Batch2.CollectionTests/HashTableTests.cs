using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;

namespace Soti.Training.Batch2.CollectionTests
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void HashTableTest1()
        {
            Hashtable myHash = new Hashtable();
            myHash.Add("first", "Reuben");
            myHash.Add("second", "Philip");
            myHash.Add("last", "Joseph");
            Assert.AreEqual(true, myHash.ContainsKey("first"));
        }
        [TestMethod]
        public void HashTableTest2()
        {
            Hashtable myHash = new Hashtable();
            myHash.Add("first", "Reuben");
            myHash.Add("second", "Philip");
            myHash.Add("last", "Joseph");
            string sent = string.Empty;
            try
            {
                myHash.Add("first", "winword.exe");
                sent = "The key is and value is added successfully";
            }
            catch
            {
                sent = "An element with Key = \"first\" already exists.";
            }
            Assert.AreEqual("An element with Key = \"first\" already exists.", sent);
        }
    }
}
