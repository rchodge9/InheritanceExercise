using System;namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             *  public string WingColor { get; set; }
            public double WingSpan { get; set; }
            public bool CanFly { get; set; }
            public bool WillMigrate { get; set; }
            public string BeakType { get; set; }
            public double BeakLength { get; set; }
            public double TailFeatherLenght { get; set; }
             * 
             * 
             */
            var myBird = new Bird();
            myBird.WingColor = "Red";
            myBird.WingSpan = 9.8;
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            myBird.BeakType = "Cone";
            myBird.BodyLength = 8.3;
            myBird.BodyLength = 1.7;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             *  public bool NeedHeatSource {get;set;}
            public bool  HasScales { get; set; }
            public string Habitat { get; set; }
             public bool CanRegrowTail { get; set; }
             public double TailLength { get; set; }
             public string ColorMarkings { get; set; }
             public double BodyWeight { get; set; }
             public double TotalLenght { get; set; }
           */
            
          
            var myReptile = new Reptile()
            {
                HasScales = true,
                NeedHeatSource = true,
                Habitat = "Desert",
                CanRegrowTail = false,
                TotalLenght = 17.5,
                ColorMarkings = "Tan, red, and yellow",
                BodyWeight = .75,

            
            };
            
            var myAnimals = new Animal[] { myBird, myReptile };
            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age}");
                Console.WriteLine($"LandSeaAir:{animal.LandSeaAir}");
                Console.WriteLine($"Leg Count:{animal.LegCount}");
                Console.WriteLine();
            }

            
             
        } 

        
    }
}
