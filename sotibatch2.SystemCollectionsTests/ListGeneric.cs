using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace sotibatch2.SystemCollectionsTests
{
    [TestClass]
    public class ListGeneric
    {
        [TestMethod]
        public void List()
        {
            List<int> numbers = new List<int>() { 1, 2, 5, 7, 8, 10 };
            numbers.Add(11);
            numbers.Remove(2);
            foreach (int a in numbers)
            {
                Console.WriteLine(a);
            }



        }
    }
}
