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
    public class Pet: IDisposable// This Name of the Clss
    {
        //string[] availableColors = { "Red", "Green", "Blue" };
        int id; // Name of a Field enum struct
        string name = "Default";
        //string category_name;
        //int category_id;
        Category cat; // User Defined Type
        long mylong;

        public string Name { get; set; }

        public Pet()
        {
            this.Name = "DEFAULT";
        }

        public Pet(string name, int id)
        {
            this.name = name;
            this.id = id;
        }

        public override string ToString()
        {
            return $"{this.name}_{this.id}"; 
        }

        public static Pet operator +(Pet a, Pet b)
        => new Pet($"{a.name}{b.name}",a.id + b.id);

        public char this[int i]
        {
            get { return this.name[i]; }
            //set { arr[i] = value; }
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
                throw new ArgumentException("This is not a valid argumen");
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
