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
            
        }

        public virtual void decelerate()
        {


        }

        public virtual void showDash()
        {


        }

        public virtual void simulate()
        {


        }



    }
}
