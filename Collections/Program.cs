using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //ArrayList
            //Here ArrayList is inbuilt class
            ArrayList myAl = new ArrayList();
            myAl.Add("Hello");
            myAl.Add("World");
            myAl.Add("!");

            //To print values of ArrayList myAl
            Console.WriteLine("Values:");
            foreach (var item in myAl)
            {
                Console.Write("{0}", item);
            }

            Console.WriteLine(" ");

            Console.WriteLine("Count: {0}", myAl.Count);
            Console.WriteLine("Capacity: {0}", myAl.Capacity);




            //DICTIONARY

            IDictionary<int, string> dict = new Dictionary<int, string>();
            //using Add() method
            dict.Add(1, "One");
            dict.Add(2, "Two");

            foreach (var item in dict)
            {
                Console.WriteLine("Key:{0} , Value:{1}", item.Key, item.Value);
            }

            var cities = new Dictionary<string, string>(){
                    {"UK", "London, Manchester, Birmingham"},
                    {"USA", "Chicago, New York, Washington"},
                    {"India", "Mumbai, New Delhi, Pune"}
                };

            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);

            Console.WriteLine("Cities of UK are {0}", cities["UK"]);  //prints value

            //ElementAt() method to retrieve key-value pair using index
            for (int i = 0; i < cities.Count; i++)
            {
                Console.WriteLine("Key: {0}, Value: {1}",
                                                        cities.ElementAt(i).Key,
                                                        cities.ElementAt(i).Value);

            }

            //update value 
            cities["UK"] = "Liverpool";
            Console.WriteLine("Cities of UK are {0}", cities["UK"]);

            //updating using ContainsKey() method
            if (cities.ContainsKey("India"))
            {
                cities["India"] = "Goa";
            }

            Console.WriteLine("Cities of India are {0} ", cities["India"]);

            //Remove a key
            cities.Remove("UK");
            foreach (var kvp in cities)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);


            //LIST
            List<int> prime = new List<int>();
            prime.Add(2); //using Add() method
            prime.Add(3);

            //using collection-initializer
            var Bigcities = new List<string>()
            {
                "New York", "London", "Chicago"
            };

            // can add an array to the list using ArrayRange() method
            string[] IndianCity = new string[2] { "Mumbai", "Goa" };
            var popularCities = new List<string>();
            popularCities.AddRange(IndianCity);

            Console.WriteLine("Indian Cities are:");
            foreach (var i in IndianCity)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Popular cities are:");
            foreach (var item in popularCities)
            {
                Console.WriteLine(item);
            }












            Console.ReadKey();
        }
    }
}
