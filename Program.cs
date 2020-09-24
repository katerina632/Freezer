using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFreezer
{
    class Fruit
    {
       public int Temperature { get; set; }        


        public Fruit()
        {
            Temperature = 0;
        }

        public Fruit(int t)
        {
            Temperature = t;
        }

        public void ShowTemperature()
        {
            Console.WriteLine($"Temperature of friut is: {Temperature}");
        }
    }

    
    class Program {      
        static void Main(string[] args)
        {
            Freezer freezer1 = new Freezer();
            Freezer freezer2 = new Freezer(100, 90, 50);
            Freezer freezer3 = new Freezer(120, 90,120, "Silver", "Indesit", true);
            Freezer freezer4 = new Freezer(215, 195, 70, "Silver", "Bosh", true );
            Freezer freezer5 = new Freezer(150, 180, 70);

            Freezer[] arr = new Freezer[5] { freezer1, freezer2, freezer3, freezer4, freezer5 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i].ToString());
            }

            Console.WriteLine("Add function NoFrost:");
            freezer1.AddNoFrostFunction();
          
            Console.WriteLine(freezer1.ToString());

            Console.WriteLine($"Color of freezer1: {freezer1.Color}");
            
            freezer1.ChangeColor("black");
            Console.WriteLine($"Color freezer1 after changing:  {freezer1.Color}");

            Console.WriteLine();
            freezer1.CompatibilityCheck(85, 50);

            Fruit fruit1 = new Fruit(12);
            Console.WriteLine($"Temperature of fruit before freezing: {fruit1.Temperature}");
            freezer1.ToFreeze(fruit1);
            Console.WriteLine($"Temperature of fruit after freezing: {fruit1.Temperature}");
        }


    }
}
