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
            myReptile.Habitat = "desert";
            myReptile.CanGrowTail = true;


            var Birdie = new Bird()
            {

                WingColor = "blue",
                CanFly = true,
                DoMigrate = true,
                BeakLength = 2.5,


            };

            var myAnimals = new Animal[] { Birdie, myReptile };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive: {animal.IsAlive}");
                Console.WriteLine($"Age: {animal.Age} years old");
                Console.WriteLine($"It has {animal.NumberOfLegs} legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
                Console.WriteLine($" ");
            }

            Console.Write($"My pet bird has {Birdie.WingColor} wings. It is {Birdie.CanFly} that my birdie can fly and {Birdie.DoMigrate} that it migrates. Birdie's beak is {Birdie.BeakLength} inches long.");
            Console.WriteLine($" ");
            Console.WriteLine($"It is {myReptile.IsColdBlooded} that I have a cold blooded reptile. Its is {myReptile.HasScales} that he has scales. It is {myReptile.CanGrowTail} that he can grow a tail and thrives in the {myReptile.Habitat}.");
            


            

        }

    }
}
