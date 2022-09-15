using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2
{
    public class Parts
    {
        string partName;
        int partId;
        public Parts(string name,int Id)
        {
            this.partName = name;
            this.partId = Id;
        }
        public override string ToString()
        {
            return $"{this.partName}_{this.partId}";
        }

        public static Parts operator +(Parts ob1, Parts ob2)
        => new Parts($"{ob1.partName}{ob2.partName}", ob1.partId + ob2.partId);

        public static Parts operator -(Parts ob1, Parts ob2)
        => new Parts($"{ob1.partName}{ob2.partName}", ob1.partId - ob2.partId);

        public static Parts operator *(Parts ob1, Parts ob2)
        => new Parts($"{ob1.partName}{ob2.partName}", ob1.partId * ob2.partId);

        public char this[int i]
        {
            get { return this.partName[i]; }
        }

    }
}
