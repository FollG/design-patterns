using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Domain
{
    internal class PersonalTrainingMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public PersonalTrainingMembership(decimal Price)
        {
            _name = "Personal training Membership";
            _price = Price;
        }

        public string Name => _name;

        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
