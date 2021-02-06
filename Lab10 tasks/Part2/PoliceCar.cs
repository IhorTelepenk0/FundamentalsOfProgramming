using System;
using System.Collections.Generic;
using System.Text;

namespace Part2
{

    interface IsEmergency
    {
        public void EmergencyCalling();
    }

    interface IsLandVehicle : IsEmergency
    {
        public void LandVehicleCalling();
    }

    class PoliceCar : IsLandVehicle
    {
        public void EmergencyCalling()
        {
            Console.WriteLine("the Emergency");
        }

        public void LandVehicleCalling()
        {
            Console.WriteLine("the vehical info");
        }
    }
}
