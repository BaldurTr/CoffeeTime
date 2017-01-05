using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeTime
{
    class CoffeeCalculations
    {
        private const int CoffeeCupSizeMl = 150;
        private const double FrenchPressGramsPerCup = 12.5;

        public int CupsToMillileters(int cups)
        {
            return cups * CoffeeCupSizeMl;
        }

        public double CupsToCoffeeGrams(string brewMethod, int cups)
        {
            if (brewMethod == "French Press")
            {
                return FrenchPressGramsPerCup * cups;
            }
            else
            {
                return 15;
            }
        }
    }
}
