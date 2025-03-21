using System;
using System.Collections.Generic;
using Bogus;
using Spectre.Console;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {

            int car_brands = int.Parse(args[0]);
            Randomizer.Seed = new Random(car_brands);

            Faker faker = new Faker();
            List<string> brands = new List<string>();
            Random random = new Random();

            for (int i = 0; i < car_brands; i++)
            {
                brands.Add(faker.Vehicle.Manufacturer());
            }


            BarChart bc = new BarChart();
            bc.Width(60);
            bc.Label("[green bold]Car Sales[/]");
            bc.CenterLabel();

            foreach (string brand in brands)
            {
                bc.AddItem(brand, random.Next(0, 20), Color.MediumPurple2);
            }

            AnsiConsole.Write(bc);
        }
    }
}
