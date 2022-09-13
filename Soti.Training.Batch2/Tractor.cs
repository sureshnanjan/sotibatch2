using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2
{
    class Tractor : Vehicle
    {
        public override void Accelerate()
        {
            throw new NotImplementedException();
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public override void Park()
        {
            Console.WriteLine("Move the Tractor to the Fields");
            base.Park();
            Console.WriteLine("Cover the Tractor with some Tarpaulin");
        }

        public void Turn() {
            
        }
    }
}
