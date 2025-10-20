namespace RPG_Character
{
    internal class Program {
        static void Main(string[] args) {
            GameWorld game = new GameWorld();
            game.CreateCharacter();

            BootsDecorator boots = new BootsDecorator(game.Player);
            boots.Preview();

            game.Player = boots;
            boots.DisplayChange();
        }
    }
}
