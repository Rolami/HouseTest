using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseTest
{
    internal class TerracedHouse : House
    {
        public override void GetMoreInfo()
        {
            Console.WriteLine("Ett radhus har ofta lägenheter i rad");
        }
    }
}
