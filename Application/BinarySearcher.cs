using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2.Application
{
    /// <summary>
    /// 
    /// </summary>
    public static class BinarySearcher
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int BinarySearch(Array array, Object value) {
            return Array.BinarySearch(array, value);
        }
    }
}
