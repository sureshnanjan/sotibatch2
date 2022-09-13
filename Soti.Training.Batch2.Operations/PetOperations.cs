using Soti.Training.Batch2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2.Operations
{
    /// <summary>
    /// Every Opeartaions on the Pets
    /// Demo The Git Tracking in VS
    /// Doing Things Only in the Suresh Branch
    /// </summary>
    public class PetOperations
    {
        // Fields
        int response_code;
        public event Action<int> uploadDone;
        public event Action<int> uploadFailure;

        // Properties
        // Methods
        /// <summary>
        /// 
        /// </summary>
        /// <param name="petId"></param>
        /// <param name="metaData"></param>
        /// <param name="filePath"></param>
        public void UploadImage(int petId,string metaData, string filePath) {

            /*PetOperations myPets = new PetOperations();
            PetOperations myPet2 = new PetOperations();
            Console.WriteLine("Suresh" + "Nanjan");
            Console.WriteLine(1+2);
            Console.WriteLine(myPets + myPet2);*/
            if (true)
            {
                uploadDone(10);
            }
            else
            {
                uploadFailure(10);
            }
            uploadDone(10); // Trigger The Event
            var myPet = new PetOperations();
            

        }

        public void CreatePet(Pet args) {
            // Json Body 
            // Send The request to the Server API End Point https://petstore.swagger.io/v2/swagger.json 
            // HTTPClient 
        }

        // Indexers
        // Operators
        // Events and Delegates
        // Enumerators 
    }
}
