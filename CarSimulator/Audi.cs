using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Audi : Car
    {
        protected string model;
        protected string make;
        protected int year;
        protected string fuelType;
        protected string soundSystem;

        public Audi(string engine, string color, 
            int doors, string make, string model, int year, string fuelType,
            string soundSystem, int seats, int windows, string driveTrain,
            string transmission)
        {
            this.doors = doors;
            this.engine = engine;
            this.color = color;
            this.make = this.GetType().ToString();
            this.model = model;
            this.year = year;
            this.soundSystem = soundSystem;
            this.seats = seats;
            this.windows = windows;
            this.driveTrain = driveTrain;
            this.fuelType = fuelType;
            this.transmission = transmission;
            this.fuelLevel = 100.0;
            this.speed = 0;
        }




    }
}
