using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public SUV()
		{

            


            Console.WriteLine("Let`s give you some advice for SUV!");
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
            Console.WriteLine("How many seats?");
            SeatNumbers = Console.ReadLine();
            int seat;
            while (!int.TryParse(SeatNumbers, out seat))
            {
                Console.WriteLine("Please enter numbers only");
                SeatNumbers = Console.ReadLine();
            }

            Console.WriteLine("Is it comfortable?");
            IsComfortable = Console.ReadLine();
            

            Console.WriteLine("Here is your summary for SUV:");
            Console.WriteLine("                    ");
            Console.WriteLine($"{Make}");
            Console.WriteLine("                 ");
            Console.WriteLine($"{Model}");
            Console.WriteLine("                   ");
            Console.WriteLine($"{Color}");
            Console.WriteLine("                    ");
            Console.WriteLine($"{Year}");
            Console.WriteLine("                      ");
            Console.WriteLine($"{Logo}");
            Console.WriteLine("                       ");
            Console.WriteLine($"{SeatNumbers}");
            Console.WriteLine("                           ");
            Console.WriteLine($"{IsComfortable}");




            
            
        }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string IsComfortable { get; set; }
        public string SeatNumbers { get; set; }
    }
}

