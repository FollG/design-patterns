using Strategy.Strategies;

namespace Strategy;

class Program
{
    public static void Main()
    {
        Hero hero = new("Hero");

        hero.SerWeapon(new M4A1());

        hero.Attack();
    }
}