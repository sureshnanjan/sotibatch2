using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2
{
    public class OClass
    {
        string name = "Default";
        int id;

        public OClass()
        {
            this.name = "DEFAULT";
        }
        public OClass(string name, int id)
        {
            this.name = name;
            this.id = id;
        }



        public static OClass operator +(OClass a, OClass b)
        => new OClass($"{a.name}{b.name}", a.id + b.id);
        public static OClass operator -(OClass a, OClass b)
        => new OClass($"{a.name}{b.name}", a.id - b.id);
        public static OClass operator *(OClass a, OClass b)
        => new OClass($"{a.name}{b.name}", a.id * b.id);

        public override string ToString()
        {
            return $"{this.name}_{this.id}";
        }
        


        public char this[int i]
        {
            get { return this.name[i]; }

        }
    }
}
