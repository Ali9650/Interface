using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_light
{
    internal class TraficColor
    {
        private static Color numberofLight;
        

        public TraficColor()
        {
            numberofLight = 0;
        }

        public static void ChangeTraficLight()
        {
            Console.WriteLine(numberofLight);
            if (numberofLight >= Color.Red) 
            {
            numberofLight = Color.Green;
            return;}

            ++numberofLight;
        }
    }
}
