using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2
{
    public class MyNumber<Type1,Type2> // Type Parameter
    {
        Type1 _valueFirst;
        Type2 _ValueSecond;
        public MyNumber(Type1 arg1)
        {
            this._valueFirst = arg1;
        }

        public override string ToString()
        {
            return $"SOTI:{this._valueFirst,-4:0}";
        }


        public T2 makeaObject<T2>() where T2: new() {
            return new T2();
        }
    }

    // MyNumber<float> myFloat = new MyNumber<float>();
    // MyNumber<int> myInt = new MyNumber<int>();
    // Assert That The type of myFloat is actially of type float not double
    // FluentAssertions Library

}
