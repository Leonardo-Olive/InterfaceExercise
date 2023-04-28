using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
            Console.WriteLine("Let`s give you some advice for Trucks!");
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
            Console.WriteLine("Is it a four-wheel driver?");
            FourWheelDrive = Console.ReadLine();
            Console.WriteLine("Is it comfortable");
            IsComfortable = Console.ReadLine();





            if ((IsComfortable.ToUpper() == "YES") || (IsComfortable.ToUpper() != "Yes") || (IsComfortable.ToUpper() != "YEs")
                || (IsComfortable.ToUpper() != "yes") || (IsComfortable.ToUpper() != "yES"))
            {
                Console.WriteLine("It is a good choice");


            }

            if ((IsComfortable.ToUpper() == "NO") || (IsComfortable.ToUpper() == "No")
                || (IsComfortable.ToUpper() == "no") || (IsComfortable.ToUpper() == "nO"))
            {
                Console.WriteLine("I would keep shopping to see if you can find something more comfortable");
            }


        }

            














        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Year { get; set; }
        public string Name { get; set; }
        public string Logo { get; set; }
        public string FourWheelDrive { get; set; }
        public string IsComfortable { get; set; }
    }

       
    }


