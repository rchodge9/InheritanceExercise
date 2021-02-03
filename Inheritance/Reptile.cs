using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        // public bool IsAlive { get; set; }
        // public int LegCount { get; set; }
        //public string LandSeaAir { get; set; }
        //public int Age { get; set; }


        public Reptile()
        {
            IsAlive = true;
            LegCount = 4;
            LandSeaAir = "Land";
            Age = 2;


        }
        public bool NeedHeatSource {get;set;}
        public bool  HasScales { get; set; }
        public string Habitat { get; set; }
        public bool CanRegrowTail { get; set; }
        public string ColorMarkings { get; set; }
        public double BodyWeight { get; set; }
        public double TotalLenght { get; set; }


    }


}
