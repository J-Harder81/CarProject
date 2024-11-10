﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    internal class Car
    {
        private string vin;
        private string make;
        private string model;
        private int mileage;

        public Car (string vin, string make, string model, int mileage)
        {
            this.vin = vin;
            this.make = make;
            this.model = model;
            this.mileage = mileage;
        }
        public Car(string vin, string make, string model)
        {
            this.vin = vin;
            this.make = make;
            this.model = model;
            this.mileage = 0;
        }
        public void Drive (int miles)
        {
            mileage += miles;
        }
        public void Display()
        {
            Console.WriteLine($"VIN: {vin}");
            Console.WriteLine($"Make: {make}");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Mileage: {mileage}");
        }
    }
}
