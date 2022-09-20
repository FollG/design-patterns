using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fabric.Domain;

namespace Fabric.Factories
{
    internal abstract class MembershipFactory
    {
        public abstract IMembership GetMembership();

    }
}
