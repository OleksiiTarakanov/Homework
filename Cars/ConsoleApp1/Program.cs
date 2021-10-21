using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Car a = new Car();
            a.name = "sedan";
            a.wheelCount = 4;
            a.speed = 10;
            a.age = 5;
            a.startTrip();

            CarTruck b = new CarTruck();
            b.name = "track";
            b.wheelCount = 6;
            b.speed = 7;
            b.age = 11;
            b.startTruckTrip();

            Car c = new Car();
            c.name = "moto";
            c.wheelCount = 2;
            c.speed = 14;
            c.age = 26;
            c.startTrip();


        }

    }
}
