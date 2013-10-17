using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Firefighter
{
    class Firetruck
    {
        public FirefighterBase Driver { get; set; }
        public void Drive(Point coordinates) 
        {
            if (Driver == null) 
            {
                return;
            }

            Console.WriteLine("{0}地点へ向けて運転中", coordinates);
        }
    }
}
