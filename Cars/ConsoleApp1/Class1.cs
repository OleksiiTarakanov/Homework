using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        public string name;
        public int age;
        public int wheelCount;
        public int speed;

        public void startTrip()
        {
           for (int i = 0; i<10; i++)
            {
                int range = speed * i;
                Console.WriteLine($"{name} is {range} km away");

                if(i == 5 && name == "moto")
                {
                    Console.WriteLine($"{name}'s engine is broken");
                    break;
                }
            }
        }
    }

    class CarTruck: Car
    {
        public void startTruckTrip()
        {
            for (int i = 0; i<25; i++)
            {
                int range = (speed * i) / 2;
                Console.WriteLine($"{name} is {range} km away");
            }
        }
    }
}
