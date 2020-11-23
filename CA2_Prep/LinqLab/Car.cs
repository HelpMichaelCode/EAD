using System;
using System.Collections.Generic;
using System.Text;

namespace LinqLab
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Registration { get; set; }
        public int EngineSize { get; set; }

        public Car (string setMake, string setModel, int setRegistration, int setEngineSize)
        {
            Make = setMake;
            Model = setModel;
            Registration = setRegistration;
            EngineSize = setEngineSize;
        }

        public override string ToString()
        {
            return $"Car Make: {Make}\n" +
                   $"Car Model: {Model}\n" +
                   $"Car Registration: {Registration}\n" +
                   $"Car Engine Size: {EngineSize}cc";
        }
    }
}
