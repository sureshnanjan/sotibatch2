namespace Soti.Training.Batch2
{
    public abstract class Vehicle
    {
        // Access Modifiers
        // Public , Private , internal, protected
        // Fields
        FuelTypeEnum fuelType;
        int mileage;
        TransmissionEnum transmission;
        int noOfWheels;
        public abstract void Accelerate();
        // Properties
        // Methods
        public abstract void Start();
        public abstract void  Stop();

        public virtual void Park() {
            System.Console.WriteLine("The Vehicle is PArked in the House Garage");
        }

        public void Turn(Direction direction) {
            switch (direction)
            {
                case Direction.Left:
                    System.Console.WriteLine("Turning Left");
                    break;
                case Direction.Right:
                    System.Console.WriteLine("Turning Right");
                    break;
                default:
                    break;
            }
        }
    }

    interface IVehicle
    {
        void Turn();
        void Start();
        void Sopt();
    }


    class Person
    {

    }

    interface IPerson
    {
        void Walk();
        void Talk();
        void Eat();
    }

    class SuperVisor
    {

    }

    class Employee
    {
        

    }

    interface IEmployee
    {
        void Work();
        void Train();
        void MarkAttendance();
        void GetPaid();
    }


    class Manager : IEmployee, IPerson
    {
        public void Eat()
        {
            throw new System.NotImplementedException();
        }

        public void GetPaid()
        {
            throw new System.NotImplementedException();
        }

        public void MarkAttendance()
        {
            throw new System.NotImplementedException();
        }

        public void Talk()
        {
            throw new System.NotImplementedException();
        }

        public void Train()
        {
            throw new System.NotImplementedException();
        }

        public void Walk()
        {
            throw new System.NotImplementedException();
        }

        public void Work()
        {
            throw new System.NotImplementedException();
        }
    }


}