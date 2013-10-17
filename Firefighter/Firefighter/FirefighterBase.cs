using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Firefighter
{
    abstract class FirefighterBase
    {
        public abstract void ExtinguishFire();

        public string Name { get; set; }

        public void Drive(Firetruck truckToDrive, Point coordinates) 
        {
            if (truckToDrive.Driver != this)
            {
                return;
            }

            truckToDrive.Drive(coordinates);
        }

    }
}
