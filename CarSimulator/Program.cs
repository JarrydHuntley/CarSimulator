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

        }
    }
}
