using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Strategies
{
    internal class Pistol : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("paw paw paw");
        }
        
    }
}
