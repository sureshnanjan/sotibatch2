﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2
{
    public class ArrList
    {
        /// <summary>
        /// Different Array List fucntions are 
        /// </summary>
        /// <param name="args"></param>
        public void ArrayList1()
        {
            ArrayList myAL = new ArrayList();
            myAL.Add("Reuben");
            myAL.Add("Joseph");
            myAL.Add("Philip");
            foreach (Object obj in myAL)
                Console.Write("   {0}", obj);
            Console.WriteLine();
        }
    }
}
