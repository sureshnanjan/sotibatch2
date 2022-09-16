using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;

namespace Soti.Training.Batch2.ApplicationTests
{
    [TestClass]
    public class Array_List
    {
        [TestMethod]
        public void ArrayList()
        {
            ArrayList arlist1 = new ArrayList();
            arlist1.Add(1);
            arlist1.Add("Bill");
            arlist1.Add(" ");
            arlist1.Add(true);
            arlist1.Add(4.5);
            arlist1.Add(null);
            int firstElement = (int)arlist1[0];
            arlist1.RemoveAt(4);
            Console.WriteLine("ArrayList 1 Elements");

            for (int i = 0; i < arlist1.Count; i++)
                Console.WriteLine(arlist1[i]);



        }
    }
}
