using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soti.Training.Batch2
{
    public class Car : Vehicle
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelarting The Car");
        }

        public override void Start()
        {
            throw new NotImplementedException();
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }
    }

    enum FuelTypeEnum
    {
        Diesel,
        Petrol,
        Electric
    }

    enum TransmissionEnum
    {
        Automatic,
        Manual
    }

    public enum Direction
    {
        Left,
        Right
    }
}
