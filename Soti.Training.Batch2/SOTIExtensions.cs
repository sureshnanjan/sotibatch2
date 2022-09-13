using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soti.Training.Batch2.Models;

namespace Soti.Training.Batch2
{
    public static class SOTIExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="original"></param>
        public static void AddSomeText(this String original) { Console.WriteLine("This Type Is Extended"); }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="original"></param>
        /// <returns></returns>
        public static int GetTheLength(this Pet original) {
            return original.Name.Length;
        }

        public static string FirstLastHypenated(this String original) {
            return $"{original[0] }-{original[original.Length-1] }";
            //return $"{original.ElementAt(0) }-{original.ElementAt(original.Length-1) }";

        }


    }
}
