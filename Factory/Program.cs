using Fabric.Domain;
using Fabric.Factories;

namespace Fabric;

class Program
{
    public static void Main()
    {
        Console.WriteLine("g - Basic,\np - Basic Plus Pool,\nt - For SuperMans\n-------------------------------------------------------------\nEnter aboniment type:");

        string membershipType = Console.ReadLine();

        MembershipFactory factory = GetFactory(membershipType);

         factory.GetMembership();

        IMembership membership = factory.GetMembership();

        Console.WriteLine("\n membership is created:\n");
        Console.WriteLine(
            $"\tName: {membership.Name}\n" +
            $"\tDesctiption:\t{membership.Description}\n" + 
            $"\tPrice:\t{membership.GetPrice()}"
            );
    }

    private static MembershipFactory GetFactory(string membership) =>
        membership.ToLower() switch 
        {
            "g" => new GymMembershipFactory(100, "Basic"),
            "p" => new GymPlusPoolMembershipFactory(250, "Good price membership"),
            "t" => new PersonalTrainingMembershipFactory(300, "super membersghip"),
            _ => null
        };


}