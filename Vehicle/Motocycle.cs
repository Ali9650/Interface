using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Motocycle : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Motocycle started");
        }

        public void Stop()
        {
            Console.WriteLine("Motocycle stopped");
        }

        public void GetDetails()
        {
            Console.WriteLine("Bu qara motosikletdir");
        }
    }
}
