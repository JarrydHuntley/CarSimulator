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
        protected string drivetrain;
        protected int seats;

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
            Console.WriteLine("Current speed is " + speed + " and fuel level is" + fuelLevel + " at " + RPM + "RPMs");

        }

        public virtual void simulate()
        {
            fuelLevel -= (RPM / speed);
        }
    }
}
