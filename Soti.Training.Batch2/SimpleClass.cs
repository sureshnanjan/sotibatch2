using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Soti.Training.Batch2
{
    public class SimpleClass: IComparable<SimpleClass>
    {
        
        int first;
        int second;
        public SimpleClass(int a1, int a2)
        {
            this.first = a1;
            this.second = a2;
        }

        public int CompareTo(SimpleClass other)
        {
            // SimpleClass is going to be compared based on the first Number
            return this.second.CompareTo(other.second);
        }

        public override string ToString()
        {
            return $"{this.first} : {this.second}";
        }
    }

    public class AnotherClass {
        int first;
        int second;
        string empId = "SOTI0012"; // "SOTI0009", "SOTI0012", "SOTI10001","SOTI0006", "SOTI0022", "SOTI10001", 
        public AnotherClass(int a1, int a2, string empId)
        {
            this.first = a1;
            this.second = a2;
            this.empId = empId;
        }

        public int CompareTo(AnotherClass other)
        {
            // SimpleClass is going to be compared based on the first Number
            //return this.second.CompareTo(other.second);
            return Int32.Parse(this.empId.Substring(4)).CompareTo(Int32.Parse(other.empId.Substring(4)));
        }

        public override string ToString()
        {
            return $"{this.first} : {this.second}";
        }

    }



    class IntComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x.CompareTo(y);
        }
    }

    class StringComparer : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return (new CaseInsensitiveComparer()).Compare(x, y);
        }
    }

    class StringComparerReversed : IComparer<string>
    {
        public int Compare(string x, string y)
        {
            return (new CaseInsensitiveComparer()).Compare(y, x);
        }
    }
}
