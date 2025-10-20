namespace RPG_Character {
    public class RobeDecorator : CharacterDecorator {
        private int Increase = 10;

        public RobeDecorator(ICharacter character) : base(character) { }

        public override int Intelligence => _character.Intelligence + Increase;

        public void Preview() {
            Console.WriteLine("Hermes Boots");
            Console.WriteLine($"Move Speed +{Increase}");
        }

        public void DisplayChange() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defense: {Defense}");
            Console.WriteLine($"Intelligence: {Intelligence} (+{Increase})");
            Console.WriteLine($"Agility: {Agility}");
            Console.WriteLine($"Move Speed: {MoveSpeed}");
        }
    }
}
