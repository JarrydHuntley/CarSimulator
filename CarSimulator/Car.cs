using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    public abstract class Car
    {
        protected double speed;
        protected double fuelLevel;
        protected int RPM;
        protected string engine;
        protected int doors;
        protected int windows;
        protected string color;
        protected string transmission;
        protected int HP;
        protected string driveTrain;
        protected int seats;

        public string FuelPercentage
        {
            get { return fuelLevel+"%"; }
        }

        public virtual void accelerate()
        {
            int tempHP = HP / 10;
            int tempRPMs = HP * 5;
            speed += tempHP;
            RPM += tempRPMs;
        }

        public virtual void decelerate()
        {
            int tempHP = HP / 10;
            int tempRPMs = HP * 5;
            speed -= tempHP;
            RPM -= tempRPMs;
        }

        public virtual void showDash()
        {
            Console.WriteLine("Current speed is " + speed + " and fuel level is " +FuelPercentage+ " at " + RPM + " RPMs");
        }

        public virtual void simulate()
        {
            if (speed > 0)
            {
                fuelLevel -= ((RPM / speed) / 2);
            }
        }
    }
}
