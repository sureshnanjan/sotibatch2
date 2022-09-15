using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2.Models
{
    public class Operators
    {
        int opnum;
        string opname;

        public Operators(string opname, int opnum)
        {
            this.opnum = opnum;
            this.opname = opname;
        }

        public override string ToString()
        {
            return $"{this.opname}_{this.opnum}";
        }

        public static Operators operator +(Operators op1, Operators op2)
        => new Operators($"{op1.opname}{op2.opname}", op1.opnum + op2.opnum);

        public static Operators operator -(Operators op1, Operators op2)
        => new Operators($"{op1.opname}{op2.opname}", op1.opnum - op2.opnum);

        public static Operators operator *(Operators op1, Operators op2)
        => new Operators($"{op1.opname}{op2.opname}", op1.opnum * op2.opnum);

        public char this[int i]
        {
            get { return this.opname[i]; }
        }
    }
}
