namespace RPG_Character
{
    internal class Program {
        static void Main(string[] args) {
            GameWorld game = new GameWorld();

            Console.WriteLine("Welcome to Cons super cool fantasy experience!");
            game.CreateCharacter();

            Console.WriteLine("You enter a forest. There are monsters. You fight them becasue what else are you gonna do?");
            game.Player.LevelUp();

            Console.WriteLine("You explore the forest more and find a chest with an item inside");
            ShieldDecorator shield = new ShieldDecorator(game.Player);
            shield.Preview();
            game.Player = shield;
            shield.DisplayChange();

            Console.WriteLine("You find a cave and fight more monsters...");
            game.Player.LevelUp();

            Console.WriteLine("You find another chest: ");
            BootsDecorator boots = new BootsDecorator(game.Player);
            boots.Preview();
            game.Player = boots;
            boots.DisplayChange();

            Console.WriteLine("You exit the cave into a desert and fight more monsters...");
            game.Player.LevelUp();

            Console.WriteLine("You find another chest: ");
            RobeDecorator robe = new RobeDecorator(game.Player);
            robe.Preview();
            game.Player = robe;
            robe.DisplayChange();

            Console.WriteLine("You enter a dungeon and fight more monsters...");
            game.Player.LevelUp();

            Console.WriteLine("You find another chest: ");
            GauntletsDecorator gauntlets = new GauntletsDecorator(game.Player);
            gauntlets.Preview();
            game.Player = gauntlets;
            gauntlets.DisplayChange();

            Console.WriteLine("You encounter a dragon and fight it...");
            game.Player.LevelUp();

            Console.WriteLine("You find another chest: ");
            CloakDecorator cloak = new CloakDecorator(game.Player);
            cloak.Preview();
            game.Player = cloak;
            cloak.DisplayChange();

            Console.WriteLine("Having completed your adventure you head home. All in a days work");
            Console.WriteLine("The End");
        }
    }
}
