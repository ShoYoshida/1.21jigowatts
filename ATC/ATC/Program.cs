using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ATC
{
    class Program
    {
        static void Main(string[] args)
        {
            Droid droid = new Droid("C-3PO");
            Console.WriteLine("ワタシハ、{0}デス。" , droid.Model);
            droid.hack();
            Console.WriteLine("ワタシハ、{0}デス。", droid.Model);
            Console.ReadKey();
        }
    }
}
