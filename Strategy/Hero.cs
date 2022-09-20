using Strategy.Strategies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class Hero
    {
        private readonly string _name;
        private IWeapon? _weapon; 
        public Hero(string name)
        {
            _name = name;
        }

        public void SerWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            Console.WriteLine("Fight");

            if (_weapon == null)
            {
                throw new Exception($"{_name} cant be without weapon");
            }

            Console.WriteLine($"{_name} ready to attack");

            _weapon.Shoot();


            Console.WriteLine($"Battle is end, {_name} win!");
        }
    }
}
