using System.Xml.Linq;

namespace RPG_Character {
    public class ShieldDecorator : CharacterDecorator {
        private int Increase = 10;

        public ShieldDecorator(ICharacter character) : base(character) { }

        public override int Defense => _character.Defense + Increase;

        public void Preview() {
            Console.WriteLine("Cobalt Shield");
            Console.WriteLine($"Defense +{Increase}");
        }

        public void DisplayChange() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defense: {Defense} (+{Increase})");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Agility: {Agility}");
            Console.WriteLine($"Move Speed: {MoveSpeed}");
        }
    }
}
