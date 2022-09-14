using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2.Collections
{
    public class HashTable
    {
        public void Hashtable1()
        {
            Hashtable myHash = new Hashtable();
            myHash.Add("firstName", "Reuben");
            myHash.Add("middleName", "Philip");
            myHash.Add("lastName", "Joseph");
            foreach(DictionaryEntry item in myHash)
            {
                Console.WriteLine("Key: {0}  Value: {1}", item.Key, item.Value);
            }
        }
        public void Hashtable2()
        {

            Hashtable myHash = new Hashtable();
            myHash.Add("firstName", "Reuben");
            myHash.Add("middleName", "Philip");
            myHash.Add("lastName", "Joseph");
            myHash.Remove("firstName");
            foreach (DictionaryEntry item in myHash)
            {
                Console.WriteLine("Key: {0}  Value: {1}", item.Key, item.Value);
            }
        }
        
    }
}
