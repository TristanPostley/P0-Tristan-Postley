using System;
using Models;

namespace UI
{
    public class OrderMenu : IMenu
    {
        public void Start()
        {
            bool exit = false;
            string input = "";
            int quantity = 0;
            do
            {
                Console.WriteLine("Let me guess, you want a Krabby Patty?");
                Console.WriteLine("[0] Plain Krabby Patty");
                Console.WriteLine("[1] Krabby Patty");
                Console.WriteLine("[2] Deluxe Krabby Patty");
                Console.WriteLine("[x] Exit");

                input = Console.ReadLine();

                Console.WriteLine("How many?");

                quantity = Console.ReadLine();

                if(quantity < 1) Console.WriteLine("Then why are you here?");

                switch (input)
                {
                    case "0":
                        selectedLocation = "Bikini Bottom";
                        break;
                    case "1":
                        selectedLocation = "Tentacle Acres";
                        break;
                    case "2":  
                        selectedLocation = "New Kelp City";
                        break;
                    case "x":
                        Console.WriteLine("Be that way.");
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("That wasn't an option");
                        break;
                }

                MenuFactory.GetMenu("name").Start(selectedLocation);

            } while (!exit);
        }
    }
}