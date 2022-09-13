using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2
{
    public class MyNumberFloat
    {
        float _value;
        public MyNumberFloat(float arg)
        {
            this._value = arg;
        }
        public MyNumberFloat()
        {

        }

        public override string ToString()
        {
            return $"SOTI:{this._value,4}"; // {<interpolationExpression>[,<alignment>][:<formatString>]}
        }
    }
    public class MyNumberInt
    {
        int _value;
        public MyNumberInt(int arg)
        {
            this._value = arg;
        }

        public override string ToString()
        {
            return $"SOTI:{this._value,-4:0}"; 
        }

        public T2 makeaObject<T2>() where T2 : new()
        {
            return new T2();
        }
    }


}
