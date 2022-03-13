using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPractice
{
    class Vehicle
    {
        string Color;
        int Year;

        public Vehicle()
        {

        }

        public Vehicle(string Color)
        {
            this.Color = Color;

        }

        public Vehicle(string Color, int Year) : this(Color)
        {
            this.Year = Year;
        }

        public void FullInfo()
        {
            Console.WriteLine($"{Color} {Year}");
        }

        public void GraduateYear()
        {
            Console.WriteLine($"{Year}");
        }


    }
}
