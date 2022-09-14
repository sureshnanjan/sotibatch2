using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace sotibatch2.SystemCollectionsTests
{
    [TestClass]
    public class QueueGeneric
    {
        [TestMethod]
        public void Queue()
        {
            Queue<int> callerIds = new Queue<int>();
            callerIds.Enqueue(1);
            callerIds.Enqueue(2);
            callerIds.Enqueue(3);
            callerIds.Enqueue(4);

            foreach (var id in callerIds)
                Console.Write(id);
            Console.WriteLine("\n");
            Console.WriteLine(callerIds.Dequeue());

            foreach (var id in callerIds)
                Console.Write(id);
        }
    }
}
