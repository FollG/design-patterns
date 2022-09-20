namespace Strategy.Strategies
{
    internal class RocketStarter : IWeapon
    {
        void IWeapon.Shoot()
        {
            Console.WriteLine("World is never be peacful again...");
        }
    }
}
