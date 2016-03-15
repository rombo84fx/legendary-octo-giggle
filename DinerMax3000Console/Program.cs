using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem("Salmon", "Fresh Norwegian Salmon with Sandefjord butter.", 25.50);
            summerMenu.AddMenuItem("Taco", "All Norwegians eat taco on Fridays", 10);
            summerMenu.HospitalDirections = "Right around the corner of 5th street. Ask for Dr. Jones";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Do not drink and code.";
            outsideDrinks.AddMenuItem("Virgin Cuba Libre", "A classic.", 10);
            outsideDrinks.AddMenuItem("Screwdriver", "Makes you hammered.", 15);

            Order hungryGuestOrder = new Order();

            foreach (var item in summerMenu.items)
            {
                hungryGuestOrder.items.Add(item);
            }

            foreach (var item in outsideDrinks.items)
            {
                hungryGuestOrder.items.Add(item);
            }

            Console.WriteLine($"The total is: {hungryGuestOrder.Total}");

            try
            {
                outsideDrinks.AddMenuItem("Himkok", "9 out 10 people recommend staying away from this drink.", 0);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}
