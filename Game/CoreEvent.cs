public class CoreEvent
{
    private Player player;

    public CoreEvent(Player player)
    {
        this.player = player;
    }

    public Player PickArchetype()
    {
        Console.WriteLine("What's your identity? ");
        Console.WriteLine("1. Warrior");
        Console.WriteLine("2. Mage");
        Console.WriteLine("3. Rogue");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                player.Stats = new EntityStats("Warrior", 150, 75, 50, 30, 0, 1);
                break;
            case 2:
                player.Stats = new EntityStats("Mage", 100, 120, 20, 40, 0, 1);
                break;
            case 3:
                player.Stats = new EntityStats("Rogue", 120, 90, 40, 80, 0, 1);
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                PickArchetype();
                break;
        }

        // Print player stats
        Console.WriteLine("Data obtained. Your stats are:");
        Console.WriteLine("Name: " + player.Stats.Name);
        Console.WriteLine("Health Point: " + player.Stats.HealthPoint);
        Console.WriteLine("Attack Power: " + player.Stats.AttackPower);
        Console.WriteLine("Defense Point: " + player.Stats.DefensePoint);
        Console.WriteLine("Agility: " + player.Stats.Agility);
        Console.WriteLine("Experience: " + player.Stats.Experience);
        Console.WriteLine("Level: " + player.Stats.Level);
        return player;
    }
}