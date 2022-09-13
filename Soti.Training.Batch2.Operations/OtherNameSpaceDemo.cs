using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Soti.Training.Batch2.Models;

namespace Soti.Training.Batch2.Operations
{
    class OtherNameSpaceDemo: AccessModifiersDemo
    {
        int field1;
        int field2;
        void Demo() {
            OtherNameSpaceDemo instance = new OtherNameSpaceDemo();
            
        }
        public OtherNameSpaceDemo(): base()
        {

        }
    }
}
