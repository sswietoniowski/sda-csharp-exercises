using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Name = "Conan";
            Item sword = new Item();
            sword.Name = "Excalibur";

            //player.Stats.XP = 60;
            player.XP = 60;
            //System.Console.WriteLine(player.Stats.XP);
            System.Console.WriteLine(player.XP);
            player.Items.Add(sword);
            foreach (var item in player.Items)
            {
                System.Console.WriteLine(item.Name);
            }
		}
    }
}
