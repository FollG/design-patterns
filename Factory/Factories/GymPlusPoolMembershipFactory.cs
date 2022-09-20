using Fabric.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Factories
{
    internal class GymPlusPoolMembershipFactory : MembershipFactory
    {
        private readonly decimal _Price;
        private readonly string _Desctiption;
        public GymPlusPoolMembershipFactory(decimal price, string desctiption)
        {
            _Price = price;
            _Desctiption = desctiption;
        }

        public override IMembership GetMembership()
        {
            GymPlusPoolMembership membership = new(_Price)
            {
                Description = _Desctiption
            };

            return membership;
        }
    }
}
