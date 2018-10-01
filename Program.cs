using System;
using System.Collections.Generic;
namespace Array_list_dict
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array

            // int[] newArray = new int[5];

            // int[] numArray = {1,2,3,4,5,6};

            // int[] array3;
            // array3 = new int[] {1,3,5,7,9};

            // int[] arrayOfInts = {1, 2, 3, 4, 5};
            // System.Console.WriteLine(arrayOfInts[0]);
            // System.Console.WriteLine(arrayOfInts[1]);
            // System.Console.WriteLine(arrayOfInts[2]);
            // System.Console.WriteLine(arrayOfInts[3]);
            // System.Console.WriteLine(arrayOfInts[4]);

            // int[] arr = {1,2,3,4};
            // System.Console.WriteLine("The first number of the arr is " + arr[0]);
            // arr[0] = 8;
            // System.Console.WriteLine("The first number of the arr is now" + arr[0]);
            //The index 0 of the arr is changed

            // string[] myCar = new string[4] {"Mazda Miata", "Ford Mustang", "Dodge Charger", "Nissan GTR"};

            // for (int idx = 0; idx < myCar.Length; idx++)
            // {
            //     System.Console.WriteLine($"I own a {myCar[idx]}");
            // }

            // foreach (string car in myCar)
            // {
            //     System.Console.WriteLine("I own a {0}", car);
            // }
            
            //  list

            // require     using System.Collections.Generic;
            // List<string> bikes = new List<string>();
            // bikes.Add("Kawasaki");
            // bikes.Add("Triumph");
            // bikes.Add("BMW");
            // bikes.Add("Mot Guzzi");
            // bikes.Add("Harley Davidson");
            // bikes.Add("Suzuki");
            
            // // System.Console.WriteLine(bikes[2]);
            // // System.Console.WriteLine("We currently know of {0} motorcycle manufacturers.", bikes.Count);
            // System.Console.WriteLine(" The current manufacturers we have seen are:");
            // for (int idx = 0; idx < bikes.Count; idx++)
            // {
            //     System.Console.WriteLine("-" + bikes[idx]);
            // }

            // bikes.Insert(2, "Yamaha");
            // bikes.Remove("Suzuki");
            // bikes.RemoveAt(0);

            // System.Console.WriteLine("List of Non-Japanese Manufacturers: ");

            // foreach(string manu in bikes)
            // {
            //     System.Console.WriteLine("-" +manu);
            // }

            // Dictionaries
            // Dictionary<string,string> profile = new Dictionary<string, string>();

            // profile.Add("Name", "Chee");
            // profile.Add("Language", "C#");
            // profile.Add("Location", "Coding Dojo");
            // System.Console.WriteLine("Firend's Profile");
            // System.Console.WriteLine("Name - " + profile["Name"]);
            // System.Console.WriteLine("From - " + profile["Location"]);
            // System.Console.WriteLine("Favorite Language - " + profile["Language"]);

            // foreach (KeyValuePair<string, string> entry in profile){
            //     System.Console.WriteLine(entry.Key + " - " + entry.Value);
            // }
            //The var keyword takes the place of a type in type-inference
            // foreach (var entry in profile)
            // {
            //     System.Console.WriteLine(entry.Key + " - " + entry.Value);
            // }
        }
    }
}
