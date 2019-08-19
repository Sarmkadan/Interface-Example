using System;
using System.Collections.Generic;

namespace InterfaceExample
{
    class Program
    {
        static void Main(string[] args)
        {

            List<ICar> cars = new List<ICar>();
            cars.Add(new BigCar());
            cars.Add(new LightWhgtCar());
            cars.Add(new FastCar());
            foreach (ICar car in cars)
            {
                car.Move(car);
            }
            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
