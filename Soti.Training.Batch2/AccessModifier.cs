using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2
{
    internal class AccessModifier: PrivateMembers
    {
        void Demo() {
            PrivateMembers instance = new PrivateMembers();
            AccessModifier instance2 = new AccessModifier();
            
        }

       


    }

    class PrivateMembers
    {
        private int privateField;
        protected int protField;
        internal int internalField;

    }
}
