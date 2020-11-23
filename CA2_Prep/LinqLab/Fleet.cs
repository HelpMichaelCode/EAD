using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text.RegularExpressions;

namespace LinqLab
{
    public class Fleet
    {
        public string FleetName { get; set; }
        List<Car> cars;
        public Fleet(string setFleetName)
        {
            FleetName = setFleetName;
            cars = new List<Car>();
        }
        public void AddCar(Car car)
        {
            cars.Add(car);

            var duplcaite = from myCar in cars group myCar by myCar.Registration into g where g.Count() > 1 select g.Key;

            if (duplcaite.Contains(car.Registration))
            {
                throw new ArgumentException("Registration numbers duplcates found!");
            }
        }
        public List<Car> CarsInAscendingOrder()
        {
            return cars.OrderBy(s => s.Registration).ToList();
        }

        public List<Car> ModelsForAllMazdaCars()
        {
            return cars.FindAll(s => s.Make == "Mazda");
        }

        public List<Car> CarsInDescendingOrderBasedOnEngineSize()
        {
            //string [] arr = new string [cars.Count];
            //for (int i = 0; i < cars.Count; i++)
            //{
            //    arr[i] = Regex.Match(cars[i].EngineSize, @"\d+").Value;
            //}


            return cars.OrderByDescending(s => s.EngineSize).ToList();
        }

        // Can use regex to retrieve the a number from a string
        // Pretty COOOOOL!!

        //public int CompareTo(Car other)
        //{
        //    return 
        //}

        public void GrabData()
        {
            // TODO:
            // Create a string array
            // Sort the numbers in descending order
            // Append to the array
            // Use the elements in teh array to override the values for the
            // EngineSize property in the list collection

            //foreach (var item in cars.OrderBy(s => Regex.Match(s.EngineSize, @"\d+").Value))
            //{
            //    Console.WriteLine(item);
            //}
        }

        public List<Car> GrabModelAndMakeFor1600CCEngineSize()
        {
            return cars.FindAll(s => s.EngineSize == 1600).ToList();
        }

        public int NumberOfCarsLessThanOrEqualsTo1600CC()
        {
            return cars.Count(s => s.EngineSize == 1600 || s.EngineSize < 1600);
        }

        public override string ToString()
        {
            return $"Fleet Name: {FleetName}";
        }


    }
}
