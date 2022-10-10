using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseTest
{
    internal class Highrise : House
    {
        public override void GetMoreInfo()
        {
            Console.WriteLine("I ett höghus bygger man ofta lägenheterna ovanpå varandra.");
        }
    }
}
