using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2
{
    public class Hash
    {
        public void hashlist()
        {
            Hashtable myhash = new Hashtable()
            {
                { 1,"dennis"},
                { 2,"deepak"},
                { 3,"alex"}
            };
            myhash.Add(5, "hello");
            myhash.Add(4, "world");
            foreach(DictionaryEntry value in myhash)
            {
                Console.WriteLine($"key value {value.Key} value of element {value.Value}");
            }
            if (myhash.ContainsKey(1))
            {
                myhash.Remove(1);
            }
            Console.WriteLine("After removal");
            foreach (DictionaryEntry value in myhash)
            {
                Console.WriteLine($"key value {value.Key} value of element {value.Value}");
            }



        }
      
    }
}
