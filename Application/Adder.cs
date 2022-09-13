using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2.Application
{
    /// <summary>
    /// This is a class for Adding Entries
    /// </summary>
    public class Adder
    {
        int first;
        int second;
        public Adder(int param1, int param2)
        {
            this.first = param1;
            this.second = param2;
        }

        /// <summary>
        /// Added sum of first and sec
        /// </summary>
        /// <returns> The added sum of first and second</returns>

        public int Add() {
            // Bug IS FIXED
            return this.first + this.second; // The BUG  
        }

        [Obsolete("Dont Use this . Use the Add method instead of this")]
        public int OldMethodToAdd(int a, int b) { return a +b; }
        
    }
}
