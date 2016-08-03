using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            Audi quattro = new Audi("V10", "Black", 2, "Quattro", 2017, "Premium", "Bose", 5, 4, "4 wheel drive", "Manual", 800);
            quattro.accelerate();
            quattro.simulate();
            quattro.showDash();
            quattro.decelerate();
            quattro.simulate();
            quattro.showDash();
            quattro.accelerate();
            quattro.accelerate();
            quattro.simulate();
            quattro.showDash();

            Console.WriteLine();
            Console.WriteLine("Starting the R8");
            Console.WriteLine();

            //adding in R8
            Audi R8 = new Audi("V12", "Red", 2, "R8", 2017, "Premium", "Bose", 5, 4, "4 wheel drive", "Manual", 1600);
            R8.accelerate();
            R8.accelerate();
            R8.simulate();
            R8.showDash();

            Car.maxSpeed = 1000;

            quattro.accelerate();
            R8.accelerate();

            Console.WriteLine();
            quattro.showDash();
            R8.showDash();


        }
    }
}
