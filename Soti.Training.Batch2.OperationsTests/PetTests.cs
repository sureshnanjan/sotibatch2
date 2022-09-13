using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Soti.Training.Batch2.Operations;
using Soti.Training.Batch2.Models;

namespace Soti.Training.Batch2.OperationsTests
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void CreatingAPet()
        {
            // UserOperations uop = new UserOperations();
            // Arrange Part 
            Pet testPet = new Pet();
            PetOperations pop = new PetOperations();
            pop.CreatePet(testPet); // ACT
            // Assert
        }
    }
}
