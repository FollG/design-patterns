using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    internal class M4A1 : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("Tr Tr Tr");
        }
    }
}
