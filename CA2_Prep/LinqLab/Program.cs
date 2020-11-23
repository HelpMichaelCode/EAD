using System;
using System.Collections.Generic;

namespace LinqLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car("Toyota", "Camry", 999, 1600),
                new Car("Toyota", "Prius", 888, 188888),
                new Car("Mazda", "Blunt", 1000, 100000),
                new Car("Bugatti", "Cherry", 1001, 90000),
                new Car("Opel", "Corsa", 2000, 1600)
            };

            Fleet fleet = new Fleet("Fleet1");
            foreach (var item in cars)
            {
                fleet.AddCar(item);
            }
            Console.WriteLine(fleet);

            //foreach(var item in fleet.CarsInAscendingOrder())
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("-----------------");
            //}

            //foreach (var item in fleet.ModelsForAllMazdaCars())
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("-----------------");
            //}

            // I'll come back to this
            //foreach (var item in fleet.CarsInDescendingOrderBasedOnEngineSize())
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("-----------------");
            //}

            //foreach (var item in fleet.GrabModelAndMakeFor1600CCEngineSize())
            //{
            //    Console.WriteLine(item);
            //    Console.WriteLine("-----------------");
            //}

            Console.WriteLine(fleet.NumberOfCarsLessThanOrEqualsTo1600CC());
        }
    }
}
