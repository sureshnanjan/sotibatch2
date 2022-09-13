using System;
using System.IO;
using Soti.Training.Batch2.Models;
using Soti.Training.Batch2.Operations;
using System.Linq;
using System.Collections.Generic;

namespace Soti.Training.Batch2
{
    class FirstProgram // Pascal Case Classes
    {
        List<string> myString;
        List<int> myInts; // Func , Action, 
        static int[] myNumbers = { 1, 2, 3 };
        delegate void MyDelegate();
        delegate int MyIntReturningDelegate(int one, int two);
        Func<int, int, int> myfclIntReturning = Add;

        delegate Pet PetDelegate();

        event MyIntReturningDelegate myEvent;
        static void Main(string[] args)
        {
            //InterfacesDemo1();
            // Non Generic Code
            MyNumberInt insInt = new MyNumberInt(100);
            Console.WriteLine(insInt);
            var myObject = insInt.makeaObject<MyNumberFloat>();
            MyNumberFloat insFl = new MyNumberFloat(100.0f);
            Console.WriteLine(insFl);
            // Generic Code
            MyNumber<int,int> mynumInt = new MyNumber<int,int>(100); // Func<int,int, float>
                                                                     //Console.WriteLine($"{mynumInt} _ {mynumFloat} _{mynumDbl}");
            ArrList myobj = new ArrList();
            myobj.list();

        }

        private static void InterfacesDemo1()
        {
            //InterfacesDemo();
            int[] arrayNumbers = { 100, 1, 10, 11, 3, 2, 0, 23, 100 };
            int[] arrayKeys = { 1, 4, 2, 3, 5, 9, 6, 7, 8 };
            List<int> listNumbers = new List<int>(new int[] { 100, 1, 10, 11, 3, 2, 0, 23, 100 });
            string[] arrayStrings = { "Abch", "Bcde", "Zarc", "Fed", "Xerc" };
            SimpleClass[] arraySimpleClass = { new SimpleClass(1, 2),
             new SimpleClass(7, 9),
             new SimpleClass(11, 55),
             new SimpleClass(13, 12),
             new SimpleClass(20, 2),
             new SimpleClass(10, 12),

            };

            Console.WriteLine("The original Array");
            foreach (var item in arrayNumbers)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Applying the Sort(key,value,Comparer)");
            Array.Sort(arrayKeys, arrayNumbers, new IntComparer());
            Console.WriteLine("The Sorted Array");
            foreach (var item in arrayNumbers)
            {
                Console.WriteLine(item);

            }


            Console.ReadKey();


            string name = "Anjana";
            //name.FirstLastHypenated(); // Output S-h // A-a


            Console.WriteLine("Before Sorting SimpleClass Array");
            foreach (var item in arraySimpleClass)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("After Sorting SimpleClass Array");
            Array.Sort(arraySimpleClass);
            foreach (var item in arraySimpleClass)
            {
                Console.WriteLine(item);
            }
        }



        private static void MyMethod() { Console.WriteLine("Inside Void and No params Method");
            Pet myPet = new Pet();
            int num = 10;
            FirstProgram pgm = new FirstProgram();
            PetDelegate returnPet = DoSomeThingforPet;
            pgm.myEvent(10, 10);

            pgm.myEvent += Add;
                        
        }

        private static Pet DoSomeThingforPet() { return new Pet(); }



        /// <summary>
        /// Sorts a range of elements in a pair of one-dimensional Array objects (one contains the keys and the o
        /// ther contains the corresponding items) based on the keys in the first Array using the specified IComparer.
        /// </summary>
        void SortOverload1Demo() { }


        /// <summary>
        /// Sorts the elements in a range of elements in a one-dimensional Array using the specified IComparer.
        /// </summary>
        void SortOverload2Demo() { }






        readonly int notchaningattribute = 100;

        private static void InterfacesDemo()
        {
            //DelegatesDemo1();
            string name = "Suresh";
            name.AddSomeText();
            Pet myPet = new Pet();
            Console.WriteLine(myPet.GetTheLength());
            myPet.Name = "This is a Test String for Name";
            Console.WriteLine(myPet.GetTheLength());

            Manager man = new Manager();
            IEmployee empl = new Manager();
            IPerson empl2 = new Manager();
            //IVehicle veh = new Manager();

            int val = 100;
            float flVal = 100.01f;
            val = (int)flVal; // Explicity Type Conversion or Type Casting
            val = (int)(1 + 2 + 1.0);
            flVal = val; // Implicit Type Conversion
        }

        private static void DelegatesDemo1()
        {
            Car ford = new Car();
            Bike bik = new Bike();
            ford.Turn(Direction.Left);
            bik.Turn(Direction.Right);
            bik.Park();
            Tractor trc = new Tractor();

            //Vehicle myVeh = new Vehicle();


            int[] numbers = { 1, 2, 3, 4, 5, 6, 7 };
            List<int> numberList = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7 });
            //DelegatesDemo();
            Action myAction = () => Console.WriteLine("This is my Custom Program"); // Lambda Expression
            Func<int, int, int> myLambdaAdder = (first, second) => first + second;
            Func<int, int, int> myLambdaMultiplier = (first, second) => first * second;
            Predicate<int> isGreaterThan10 = arg => arg > 10;


            myAction();
            Console.WriteLine(myLambdaAdder(20, 10));
            Console.WriteLine(myLambdaMultiplier(20, 10));
            PetOperations myOps = new PetOperations();
            myOps.uploadDone += arg => Console.WriteLine("This is the Way I handle Upload Success");
            myOps.uploadFailure += arg => Console.WriteLine("This is the way I handle Failures");
            Console.WriteLine($"When I add and aggregate {numbers.Aggregate((a1, a2) => a1 + a2)}");
            Console.WriteLine($"When I multiply and aggregate {numbers.Aggregate((a1, a2) => a1 * a2)}");
            Console.WriteLine($"When I subtract and aggregate {numbers.Aggregate((a1, a2) => a2 - a1)}");

            Console.WriteLine($"Checking 100 Greater that 10 :{isGreaterThan10(100)}");
            Console.WriteLine($"Checking 9 Greater that 10 :{isGreaterThan10(9)}");
            Console.WriteLine($"Checking -100 Greater that 10 :{isGreaterThan10(-100)}");
        }

        private static void DelegatesDemo()
        {
            //EventsDemo();
            MyDelegate myReferenec = MyMethod;
            Action myfclDel = MyMethod;
            //MyDelegate varDel = Add;
            MyIntReturningDelegate meth = Add;

            // myReferenec();
            InvokeMethods(MyMethod, SecondMethod, meth);
        }

        private static void SecondMethod() { Console.WriteLine("This is another Method"); }


        private static void InvokeMethods(MyDelegate first, MyDelegate Second, MyIntReturningDelegate third) {

            first();
            Second();
            third(10,20);

            //Action<MyDelegate, MyDelegate, MyIntReturningDelegate> myMethod = InvokeMethods;

            //Func<MyDelegate,MyDelegate,MyIntReturningDelegate>

        
        
        }

        private static void EventsDemo()
        {
            Console.CancelKeyPress += (sender, cancel) => Console.WriteLine("This is when Control Break is pressed");
            //AsyncMethodsDemo();
            PetOperations myPets = new PetOperations();
            PetOperations myPets1 = new PetOperations();
            var myOtherPet = new PetOperations();
            var myNumber = 10;
            myPets.uploadDone += (a) => Console.WriteLine("This is triggered when Upload Happens");
            myPets.uploadDone += (a) => Console.WriteLine("This is Another Operation once uplad completes");
            myPets.uploadDone += (a) => Console.WriteLine("This is Yet another operation triggered when Upload Happens");

            Console.WriteLine("Event Triggered First Time");
            myPets.UploadImage(10, "", "");
            Console.WriteLine("Event Triggered Second Time");
            myPets.UploadImage(10, "", "");

            Pet dog = new Pet();
            PetOperations Ops = new PetOperations();
            Ops.CreatePet(dog);
            //var details = Ops.GetDetails();
            //Ops.UploadImage(dog);
        }

        private static void AsyncMethodsDemo()
        {
            string[] websites = { "http://www.soti.net", "http://www.google.co.in" };
            Downloader client = new Downloader(websites, "sync");
            Downloader client2 = new Downloader(websites, "async");
            Console.WriteLine($"Synchronous Operation took {client.Totalduration} ms");
            foreach (var item in client.Results)
            {
                Console.WriteLine($"Data from {item.Site} took {item.Duration} ms to Download {item.DataResults1.Length} bytes of Data ");
            }

            Console.WriteLine($"ASynchronous Operation took {client2.Totalduration} ms");
            foreach (var item in client2.Results)
            {
                Console.WriteLine($"Data from {item.Site} took {item.Duration} ms to Download {item.DataResults1.Length} bytes of Data ");
            }
        }

        static void ExceptionThrowingLogic(int param) {

            if (param > 0)
            {
                int variable = 0;
                Console.WriteLine("Insdie The Exception Program");

                variable = int.MaxValue;

                int result = variable + param;

                Console.WriteLine(variable / param);
            }
            else
            {
                Console.WriteLine("Cannot Divide");
            }
            

        
        }

        static void ExceptionHandled(int param) {
            Console.WriteLine(param);
            BinaryReader br;
            try
            {
                br = new BinaryReader(new FileStream(Path.Combine("", ""), FileMode.Open));
            }
            catch (ArgumentNullException)
            {

                Console.WriteLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("The file path was not correct going ahead with the default path");
                br = new BinaryReader(new FileStream(Path.Combine("default", "file.txt"), FileMode.Open));
                throw;
            }
            catch (Exception) { }

            br = new BinaryReader(new FileStream(Path.Combine("default", "file.txt"), FileMode.Open));
            int number = 100;
            try
            {
                br.Read();
            }
            catch (DivideByZeroException)
            {

                Console.WriteLine("YOu cannot Divide");
            }

            try
            {

            }
            catch (Exception) { }
            finally
            {
                Console.WriteLine();

            }
        }


        static void FinallyDemo(int param) {
            try
            {
                int result = 100 / param;
            }
            catch (Exception ex) { Console.WriteLine($"Because of param value {param} {ex.Message}"); }
            finally
            {
                Console.WriteLine($"Will run always {param}");
            }
        }

        private static void Day1Code()
        {
            const int notchanging = 200;
            int? counter = 10; // Primitive Type 4 Bytes
            counter = null;

            int petage = 8;
            byte? smallNumber = 12; // 1 Byte
            smallNumber = null;
            long myHugeNumber = 100L; //8 Butes
            Pet jimmy = new Pet(); // User Defined Type
            float marks_obtained = 8.6f; // float literal
            double marks_obtained_dbl = 8.6; // Literals double
            decimal mystockValue = 100;
            string name = "Suresh"; // String Literals
            Console.WriteLine(Console.BackgroundColor);
            Console.WriteLine(Console.ForegroundColor);
            Console.Beep();
            Console.Beep();
            UserOperations uop = new UserOperations();

            Console.WriteLine("This is the user who is running this program" + Environment.UserDomainName + "\\" + Environment.UserName);
            // String Interpolation
            Console.WriteLine($"This is the user whi is runninhg tehi sprogram {Environment.UserDomainName} \\ {Environment.UserName}");

            Pet myPet = new Pet();
            //myPet.
            //string name = "Suresh";

            UserOperations uop1 = new UserOperations();
            uop1.createUsersFromArrayInput("", new string[] { }, "");
            File.CreateText("sample.txt");
        }

        public void addUsersToPetstore() {  // Camel Case startswithlowerVerb subsequest word ar capitliase

        }

        public void aMethod()
        {  // Name of a method

        }

        public void variableTypes() {
            // Primitive - Part of FCL
            // User Defined - USer have to to Define

            // Value Types
            int mynumber = 10; // Value Type
            mynumber += 100;

            MyStruct toHoldStruct = new MyStruct();
            MyEnum today = MyEnum.tuesday;

            // Reference Types
            Pet myPet = null; // Reference Type
            string name = "Value";
            int[] mylistOfValues = { 1, 2, 3, 4 };
            int[] mysingleArray = { 1 };
            Pet[] myPets = new Pet[] { new Pet(), new Pet() };
            Console.WriteLine(name); // FFCCEE

            Add(10, 20); // Argument Passing By Position
            Add(second: 30, first: 40); // Argument Passing BY Name
            Add(12.0f, 10);
            Add(second: 10, first: 12.0f);
            Add(mylistOfValues); // Take a Array Parameters
            Add(1,2,3,4,5,6); // Optional Arguments one or more 
            Add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12);
            Add(1, 2);

            // Reference Types 
            // Value Types



        }

        static void CallingMethod() {
            int originalInt = 1111;
            string originalString = "ORIGINAL";
            Pet originalPet = new Pet();
            originalPet.Name = "Original Pet";
            Console.WriteLine($"The Values for OriginalInt Before Calling {originalInt}");
            Console.WriteLine($"The Values for OriginalString Before Calling {originalString}");
            Console.WriteLine($"The Values for OriginalPet Before Calling {originalPet.Name}");
            CalledMethod(ref originalInt);
            CalledMethod(ref originalString);
            CalledMethod(originalPet);
            Console.WriteLine($"The Values for OriginalInt After Calling {originalInt}");
            Console.WriteLine($"The Values for OriginalString After Calling {originalString}");
            Console.WriteLine($"The Values for OriginalPet After Calling {originalPet.Name}");

        }

        static void DemoOutKeyword()
        {
            int age;
            string name;
            float marks;
           // Stocke Quote
            //Console.WriteLine($"Age:{age} - Name : {name} - Marks: {marks}");
            InitilaizeManyThings(out age, out name, out marks);
            Console.WriteLine($"CAlling Method: Age:{age} - Name : {name} - Marks: {marks}");
        }

        static void InitilaizeManyThings(out int age, out string name, out float marks) {
            //Console.WriteLine($"Age:{age} - Name : {name} - Marks: {marks}");
            age = 35;
            name = "My User";
            marks = 45.89f;
            Console.WriteLine($"Called Method: Age:{age} - Name : {name} - Marks: {marks}");

        }
        static void CalledMethod(ref int param) {
            Console.WriteLine($"The original Passed Value {param}");
            //param = 8999;
            Console.WriteLine($"The Changed Value {param}");

        }

        static void CalledMethod(ref string param) {
            Console.WriteLine($"The original Passed Value {param}");
            param = "CHANGED IN CALLED METHOD";
            Console.WriteLine($"The Changed Value {param}");
        }

        static void CalledMethod(Pet param)
        {
            Console.WriteLine($"The original Passed Value {param.Name}");
            param.Name = "CHANGED IN CALLED METHOD";
            Console.WriteLine($"The Changed Value {param.Name}");
        }


        public void WhichIsGreater(int first, int second) {
            // Check whether first if greater than second
            if ((first > second) && (first < second))
            {
                Console.WriteLine("The First Number is greater");
            }
        }

        static void DisplayFileTypes(string location) {
            // File and The Directory Classes in System.IO
            // Read all files and directrioes in the location 
            // If its a file display 
            // Extension 
            // Size
            // If its a Directory Display Its Size and How Many entries inside it
            if (Directory.Exists(location))
            {
                foreach (var item in Directory.EnumerateDirectories(location))
                {
                    DirectoryInfo di = new DirectoryInfo(item);
                    Console.WriteLine($"Directory Name : {di.FullName}");

                }

                foreach (var item in Directory.EnumerateFiles(location))
                {
                    FileInfo fi = new FileInfo(item);
                    Console.WriteLine($"File Name: {fi.FullName}");
                    Console.WriteLine($"File Extention Type: {fi.Extension}");
                    Console.WriteLine($"File Size: {fi.Length}");
                }
            }

            Add2Integers(10, 100);
            Add2Float(10.0f, 12.3f);
            // Add2Float(new Pet(), new Pet()); Method Overloading
            CarforDriving skoda = new CarforDriving();
            CarforDriving ford = new CarforDriving("sedan", "manual", 4, FuelType.diesel, 5);


        }

        static int Add(int first, int second) {
            Console.WriteLine(" Calling: Add (int first, int second) ");
            return first + second;
        } // Signature
        static int Add(int first, int second, params int[]  others)
        {
            Console.WriteLine(" Calling: Add(int first, int second, params int[]  others) ");
            if (others.Length == 0)
            {
                return first + second;
            }
            else
            {
                int result = first + second;
                foreach (var item in others)
                {
                    result += item;
                }
                return result;
            }
            
        }


        static int Add(int[] parameters) {
            int result = 0;
            foreach (var item in parameters)
            {
                result += item;
            }
            return result;
        }

        static float Add(int first, float second) { return first + second; }

        static float Add(float first, int second) { return first + second; }
        static int Add(int first, int second, int third) { return first + second +third; }

        static float Add(float first, float second) { return first + second; }


        static int Add2Integers(int first, int second) {
            return first + second;
        }

        static float Add2Float(float first, float second)
        {
            return first + second;
        }


    }

    // Car Manufacturer
    class CarforManufacture
    {
        //Models
        // Essential Details about an Entity is captured
    }
    
    
    // Car Owner
    class CarforDriving
    {
        // Fields
        string cls; // Hatch , Sedan
        string GearType;
        int wheels;
        FuelType type_fuel;
        static int seatCapacity;


        // Saftey
        // Fuel Efficientcy
        // Cost 

        // public, private 


        // Properties
        // Read Only 
        public static int SeatCapacity { get => seatCapacity; }
        // Read Write
        public int Wheels { get => wheels; set => wheels = value; }
        // Methods


        // Constructors
        public CarforDriving()
        {
            this.cls = "HatchBack";
            GearType = "automatic";
            this.wheels = 4;
            this.type_fuel = FuelType.electric;
            //this.seatCapacity = 5;
        }

        public CarforDriving(string cls, string gearType, int wheels, FuelType type_fuel, int seatCapacity)
        {
            this.cls = cls;
            GearType = gearType;
            this.wheels = wheels;
            this.type_fuel = type_fuel;
            //this.seatCapacity = seatCapacity;
        }

        public void Lock() { }

        public void Unlock() { }

        public void Start() { }

        public void Drive() { }



        // Constructors


        // Events
        // Indexers
        // Operators


    }

    enum FuelType
    {
        diesel,
        petrol,
        electric,
        hydrogen,
        solar

    }

    
}
