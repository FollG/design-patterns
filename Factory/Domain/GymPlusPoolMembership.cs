using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Domain
{
    internal class GymPlusPoolMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public GymPlusPoolMembership(decimal Price)
        {
            _name = "Gym and Pool Membership";
            _price = Price;
        }

        public string Name => _name;

        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
