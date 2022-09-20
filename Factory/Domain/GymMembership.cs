namespace Fabric.Domain
{
    internal class GymMembership : IMembership
    {
        private readonly string _name;
        private readonly decimal _price;

        public GymMembership(decimal Price)
        {
            _name = "Gym Membership";
            _price = Price;
        }

        public string Name => _name;

        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }
}
