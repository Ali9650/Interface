using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    internal class Bus : IVehicle
    {
        public void Start()
        {
            Console.WriteLine("Bus started");
        }

        public void Stop()
        {
            Console.WriteLine("Bus stopped");
        }

        public void GetDetails()
        {
            Console.WriteLine("Bu qara avtobusdur");
        }
    }
}
