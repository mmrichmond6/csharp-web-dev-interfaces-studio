using System;
using System.Collections.Generic;
using System.Text;

namespace SpinningDiscs
{
    public interface IOpticalDisc
    {
        //Declare and initialize any constants?

        private const int spinRateMin = 0;
        public int SpinRateMin { get { return spinRateMin; } }

        private const int spinRateMax = 0;
        public int SpinRateMax { get { return spinRateMax; } }

        //Add a method signature for each of the behaviors identified
        void SpinDisc()
        {
            Console.WriteLine("This media spins at a rate of " + SpinRateMin + " - " + SpinRateMax + " rpm.");
        }

        void StoreData()
        {
        }


    }
}
