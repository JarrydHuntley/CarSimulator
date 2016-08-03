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
            int doors, string model, int year, string fuelType,
            string soundSystem, int seats, int windows, string driveTrain,
            string transmission, int HP)
        {
            this.doors = doors;
            this.engine = engine;
            this.color = color;
            this.model = model;
            this.year = year;
            this.soundSystem = soundSystem;
            this.seats = seats;
            this.windows = windows;
            this.driveTrain = driveTrain;
            this.fuelType = fuelType;
            this.transmission = transmission;
            this.HP = HP;

            this.make = this.GetType().ToString();
            this.fuelLevel = 100.0;
            this.speed = 0;
        }

        public override void simulate()
        {
            if (speed > 0)
            {
                fuelLevel -= ((RPM / speed) / 4);
            }
            
        }


    }
}
