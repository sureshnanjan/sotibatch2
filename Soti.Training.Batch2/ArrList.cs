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
            string sent = string.Empty;
            foreach (String var in myAL)
            {
                sent = sent + " " + var.ToString();
            }
            Console.WriteLine(sent.Trim());
        }
        public void ArrayList2()
        {
            ArrayList myAL = new ArrayList();
        }
    }
}
