using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFreezer
{
    partial class Freezer
    {
        public override string ToString()
        {
            char noFrost;
            if (IsNoFrost)
                noFrost = '+';
            else
                noFrost = '-';

            return $"Brand: {Brand}\n" +
                   $"Color: {Color}\n" +
                   $"H x W: {height} x {width}\n" +
                   $"Volume: {volume}\n" +
                   $"Function NoFrost: {noFrost}\n" +
                   $"Default temperature: {defaultTemperature}\n";
        }

        public void AddNoFrostFunction()
        {
            if (!IsNoFrost)
                IsNoFrost = true;
            else
                Console.WriteLine("This model already has a NoFrost function!");

            Console.WriteLine();
        }

        public void ChangeColor(string color)
        {
            Color = color;
        }

        public void CompatibilityCheck(double h, double w) //perevirka, chu gabaryty morozylky pidhodjat' pokupcju
        {
            if (height >= h || width >= w)
                Console.WriteLine("The dimensions of the freezer do not fit the specified parameters!");
            else
                Console.WriteLine("The dimensions of the freezer are suitable for these parameters!");
        }

        public void ToFreeze(Fruit fruit)
        {
            fruit.Temperature = defaultTemperature;
        }
    }
}
