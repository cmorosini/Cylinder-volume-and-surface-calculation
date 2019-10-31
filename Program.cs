using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_8___User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.141592654;

            Console.WriteLine("Let's work out the volume and surface of a cylinder!\nEnter the height: ");
            string height = Console.ReadLine();
            Console.WriteLine("Enter the radius of the base: ");
            string radius = Console.ReadLine();

            double heightConverted = Convert.ToDouble(height);
            double radiusConverted = Convert.ToDouble(radius);

            double volume = pi * radiusConverted * radiusConverted * heightConverted;
            double surface = 2 * pi * radiusConverted * (radiusConverted + heightConverted);

            Console.WriteLine("Height = {0} and radius = {1}. The volume of your cylinder is {2} and the surface is {3}.",
                heightConverted, radiusConverted, volume, surface);

            // String interpolation
            // Console.WriteLine($"The cylinder's volume is: {volume} cubic units."); 
        }
    }
}
