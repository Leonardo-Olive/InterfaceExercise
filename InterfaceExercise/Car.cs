using System;
using System.Runtime.ConstrainedExecution;

namespace InterfaceExercise
{
	public class Car: IVehicle , ICompany
	{
		public Car()
		{



            Console.WriteLine("Let`s give you some advice for Sedan!");
            Console.WriteLine("                    ");
            Console.WriteLine("Please, enter the maker of the car you wish to purchase:");
            Make = Console.ReadLine();
            Console.WriteLine("Now, let`s pick a model:");
            Model = Console.ReadLine();
            Console.WriteLine("Choose a color:");
            Color = Console.ReadLine();
            Console.WriteLine("What year?");
            Year = Console.ReadLine();
            int year;
            
            while (!int.TryParse(Year, out year))
            {
                Console.WriteLine("Please enter numbers only");
                Year = Console.ReadLine();
            }

               
                Console.WriteLine("What is the logo for the Maker?");
            Logo = Console.ReadLine();
            Console.WriteLine("Does it have a big trunk?");
            HasBigTrunk = Console.ReadLine();
            Console.WriteLine("And how many seats?");
            NumberOfSeats = Console.ReadLine();
            int seat;
            while (!int.TryParse(NumberOfSeats, out seat))
            {
                Console.WriteLine("Please enter numbers only");
                NumberOfSeats = Console.ReadLine();
            }
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        
        public string Logo { get; set; }
        public string HasBigTrunk { get; set; }
        public string NumberOfSeats { get; set; }
        public string Name { get; set ; }
        
    }
}

