using Fabric.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fabric.Factories
{
    internal class GymMembershipFactory : MembershipFactory
    {
        private readonly decimal _Price;
        private readonly string _Desctiption;
        public GymMembershipFactory(decimal price, string desctiption)
        {
            _Price = price;
            _Desctiption = desctiption;
        }

        public override IMembership GetMembership()
        {
            GymMembership membership = new(_Price)
            {
                Description = _Desctiption
            };

            return membership;
        }
    }
}
