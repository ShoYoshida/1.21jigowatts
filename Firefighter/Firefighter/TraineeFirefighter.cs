using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Firefighter
{
    class TraineeFirefighter : Firefighter
    {
        private bool hoseTrainedOnFire;

        protected override void TurnOnHose()
        {
            if (hoseTrainedOnFire)
            {
                Console.WriteLine("火は消えつつあります。");
            }
            else 
            {
                Console.WriteLine("あちこちに水がばらまかれています！！");
            }

        }

        protected override void TrainHoseOnFire()
        {
            hoseTrainedOnFire = true;
            Console.WriteLine("ホースに火を向けています。");
        }


    }
}
