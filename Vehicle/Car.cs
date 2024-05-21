using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Car : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Car started");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped");
        }

        public void GetDetails()
        {
            Console.WriteLine("Bu qara masindir");
        }
    }
}
