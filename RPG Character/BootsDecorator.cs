namespace RPG_Character {
    public class BootsDecorator : CharacterDecorator {
        private int Increase = 10;

        public BootsDecorator(ICharacter character) : base(character) { }

        public override int MoveSpeed => _character.MoveSpeed + Increase;

        public void Preview() {
            Console.WriteLine("Hermes Boots");
            Console.WriteLine($"Move Speed +{Increase}");
        }

        public void DisplayChange() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defense: {Defense}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Agility: {Agility}");
            Console.WriteLine($"Move Speed: {MoveSpeed} (+{Increase})");
        }
    }
}
