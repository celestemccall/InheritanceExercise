using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Done - Create a class Animal
            // Done - give this class 4 members that all Animals have in common


            // Done - Create a class Bird
            // Done - give this class 4 members that are specific to Bird
            // Done - Set this class to inherit from your Animal Class

            // Done - Create a class Reptile
            // Done - give this class 4 members that are specific to Reptile
            // Done - Set this class to inherit from your Animal Class


            /* DONE - Create an object of your Reptile class
             * DONE - give values to your members using the object of your Reptile class
             *  
             * DONE -Creatively display the class member values 
             */

            /* DONE - Create an object of your Bird class
             * DONE -give values to your members using the object of your Bird class
             *  
             * DONE - Creatively display the class member values 
             */


            var myReptile = new Reptile();

            myReptile.IsColdBlooded = true;
            myReptile.HasScales = true;
            myReptile.TypeOfMeals = "Mice";
            myReptile.NumberOfDailyMeals = 3;


            var Birdie = new Bird()
            {

                OwenerName = "Yisel",
                CagedBird = true,
                Color = "Blue",
                Weight = "5 lbs",


            };

            var myAnimals = new Animal[] { Birdie, myReptile };

            foreach( var animal in myAnimals)
            {
                Console.WriteLine($"Number of legs: {animal.NumberOfLegs}");
                Console.WriteLine($"Age: {animal.Age}");
                Console.WriteLine($"Has an owner: {animal.HasAnOwner}");
                Console.WriteLine($"Sleeps with owner: {animal.SleepsWithOwner}");
                Console.WriteLine($"");
            }

            Console.Write($"My mom {Birdie.OwenerName} has a bird named Birdie. It is {Birdie.CagedBird} that Birdie lives in a cage. Birdie is {Birdie.Color} and weighs {Birdie.Weight}.");
            Console.WriteLine($"");
            Console.WriteLine($"It is {myReptile.IsColdBlooded} that I have a cold blooded reptile. Its is {myReptile.HasScales} that he has scales. He normally eats {myReptile.TypeOfMeals} and eats {myReptile.NumberOfDailyMeals} times a day.");


        }

    }
}
