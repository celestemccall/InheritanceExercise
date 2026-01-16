using System;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAlive = true;
            NumberOfLegs = 4;
            LandSeaAir = "Land";
            Age = 2;
            
        }
        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public string Habitat { get; set; }
        public bool CanGrowTail { get; set; }
    }
}
