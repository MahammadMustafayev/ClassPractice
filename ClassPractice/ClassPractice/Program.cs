using System;

namespace ClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car("Black",1,"BMW","M5",70,1);
            c1.ShowInfo();
            c1.Drive(10);



        }
    }
}
