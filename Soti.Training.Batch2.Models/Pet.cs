using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2.Models
{
    /// <summary>
    /// This is the Type for represting pets in the Petstore
    /// </summary>
    public class Pet // This Name of the Clss
    {
        int id; // Name of a Field enum struct
        string name = "Default";
        
        //string category_name;
        //int category_id;
        Category cat; // User Defined Type
        /// <summary>
        /// 
        /// </summary>
        long mylong;
        


        public string Name { get; set; }

        public Pet()
        {
            this.Name = "DEFAULT";
        }

        



        /// <summary>
        /// 
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        public void TestMethod(int param1, string param2) {
            if (true)
            {
                throw new ArgumentException("This is not a valid argumen");
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="param1"></param>
        /// <param name="param2"></param>
        /// <returns></returns>
        /// <exception cref=""></exception>
        /// <example>
        /// <code>
        /// </code>
        /// </example>
        public Pet CreatePet(int param1, string param2)
        {
            if (true)
            {
                throw new ArgumentException("This is not a valid argument");
            }
        }

    }
}
