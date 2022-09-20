using Fabric.Domain;

namespace Fabric.Factories
{
    internal class PersonalTrainingMembershipFactory : MembershipFactory
    {
        private readonly decimal _Price;
        private readonly string _Desctiption;
        public PersonalTrainingMembershipFactory(decimal price, string desctiption)
        {
            _Price = price;
            _Desctiption = desctiption;
        }

        public override IMembership GetMembership()
        {
            PersonalTrainingMembership membership = new(_Price)
            {
                Description = _Desctiption
            };

            return membership;
        }
    }
}
