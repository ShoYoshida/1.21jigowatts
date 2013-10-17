using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Firefighter
{
    class Firefighter : FirefighterBase
    {
        public override void ExtinguishFire()
        {
            Console.WriteLine("{0}は消化中です！", Name);
            TrainHoseOnFire();
            TurnOnHose();
        }

        protected virtual void TurnOnHose()
        {
            Console.WriteLine("火は消えつつあります。");
        }

        protected virtual void TrainHoseOnFire()
        {
            Console.WriteLine("ホースに火を向けています。");
        }
    }
}
