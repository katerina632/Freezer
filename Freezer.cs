using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFreezer
{
    partial class Freezer
    {
        int volume;
        double height;
        double width;        

        static int defaultTemperature;
        static int count;

        public string Color { get; private set; }
        public string Brand { get; set; }
        public bool IsNoFrost { get; private set; }

        public double Height
        {
            get { return height; }

            set
            {
                if (value >= 84.5 && value <= 195)
                    height = value;
                else
                    height = 84.5;
            }
        }

        public double Width
        {
            get { return width; }

            set
            {
                if (value >= 47.5 && value <= 150)
                    width = value;
                else
                    width = 47.5;
            }
        }

        public int Volume
        {
            get { return volume; }

            set
            {
                if (value >= 65 && value <= 467)
                    volume = value;
                else
                    volume = 65;
            }
        }

        static Freezer()
        {
            count = 0;
            defaultTemperature = -18;
        }

        public Freezer()
        {
            volume = 65;
            height = 84.5;
            width = 47.5;
            Color = "white";
            Brand = "Beko";
            IsNoFrost = false;

            count++;
        }

        public Freezer(int vol, double h, double w, string color, string brand, bool noFrost )
        {
            volume = vol;
            height = h;
            width = w;
            Color = color;
            Brand = brand;
            IsNoFrost = noFrost;

            count++;
        }

        public Freezer(int vol, double h, double w) : 
            this(vol, h, w, "white", "Beko", false) { }      
        
    }
}
