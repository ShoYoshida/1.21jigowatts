using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Firefighter
{
    class Program
    {
        static void Main(string[] args)
        {
            Firefighter joe = new Firefighter { Name = "Joe" };
            joe.ExtinguishFire();

            Firefighter bill = new TraineeFirefighter { Name = "bill" };
            bill.ExtinguishFire();


            Console.ReadKey();

        }
    }
}
