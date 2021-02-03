using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class


   public class Bird: Animal
    {
      


        public Bird()
        {
            IsAlive = true;
            LegCount = 2;
            LandSeaAir = "Air";
            Age = 1;
        }
      public string WingColor { get; set; }
        public double WingSpan { get; set; }
        public bool CanFly { get; set; }
        public bool WillMigrate { get; set; }
        public string BeakType { get; set; }
      public double BodyLength { get; set; }
        public double BodyWeight { get; set; }

    }

    public class Dove:Bird
    {
        


    }
}
