using System;
using Bogus;
using Spectre.Console;

namespace CarStats
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Randomizer.Seed = new Random(int.Parse(args[1]));
            string brands = new Faker().Vehicle.Manufacturer();
            int car_number = new Faker().Random.Number(1, 20);


            BarChart bc = new BarChart();
            AnsiConsole.Write(new BarChart()
         .Width(60)
         .Label("[green bold underline]Car Sales[/]")
         .CenterLabel()
         .AddItem(brands, car_number, Color.Yellow)
         .AddItem(brands, car_number, Color.Green)
         .AddItem(brands, car_number, Color.Red));

        }
    }
}
