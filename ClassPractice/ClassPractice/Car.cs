using System;
using System.Collections.Generic;
using System.Text;

namespace ClassPractice
{
    class Car:Vehicle
    {
        string Color;
        int Year;
        string Brand;
        string Model;
        int FuelCapacity;
        double FuelFor1Km;
        double CurrentFuel;

        public Car()
        {

        }
        public Car(string Color) : base(Color)
        {

        }
        public Car(string Color, int Year) : base(Color, Year)
        {

        }



        public Car(string Color, int Year, string Brand)
        {
            this.Brand = Brand;

        }

        public Car(string Color, int Year, string Brand, string Model) : this(Color, Year, Brand)
        {
            this.Model = Model;
        }
        public Car(string Color, int Year, string Brand, string Model, int FuelCapacity) : this(Color, Year, Brand, Model)
        {
            this.FuelCapacity = FuelCapacity;
        }

        public Car(string Color, int Year, string Brand, string Model, int FuelCapacity, int FuelFor1Km) : this(Color, Year, Brand, Model, FuelCapacity)
        {
            this.FuelFor1Km = FuelFor1Km;
        }

        public Car(string Color, int Year, string Brand, string Model, int FuelCapacity, int FuelFor1Km, int CurrentFuel) : this(Color, Year, Brand, Model, FuelCapacity, FuelFor1Km)
        {
            this.CurrentFuel = CurrentFuel;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"{Brand} {Model} {FuelCapacity} {FuelFor1Km}");
        }

        

        public void Drive()
        {

            CurrentFuel = FuelCapacity - FuelFor1Km;
            Console.WriteLine("CurrentFuel:" + CurrentFuel);
        }













    }
}
