using System;
using Spectre.Console;

namespace LevelTwo
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                string image_name = args[0];



                CanvasImage tux = new CanvasImage("tux.jpg");

                tux.MaxWidth(24);

                AnsiConsole.Write(tux);
            }
            else
            {
                string image_width = args[1];
                string image_name = args[0];
                int width = int.Parse(image_width);
                CanvasImage image = new CanvasImage(image_name);
                image.MaxWidth(width);

                AnsiConsole.Write(image);
            }

        }
    }
}