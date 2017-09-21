using System;

namespace TipCalculator
{
    public class Tipper
    {
        public double Amount { get; set; }

        public double CalculateTip(double percentage)
        {
            return Amount * percentage / 100.0;
        }

        public double CalculateTip()
        {
            // Chain through the other version of this method - 
            // this is a common technique to avoid writing the same
            // code (and debugging it) twice.
            return CalculateTip(15.0);
        }

        public double Divvy(int diners)
        {
            return Amount / diners;
        }
    }
}

