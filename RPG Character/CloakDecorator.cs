using System.Xml.Linq;

namespace RPG_Character {
    public class CloakDecorator : CharacterDecorator {
        private int Increase = 10;

        public CloakDecorator(ICharacter character) : base(character) { }

        public override int Agility => _character.Agility + Increase;

        public void Preview() {
            Console.WriteLine("Mist Cloak");
            Console.WriteLine($"Agility +{Increase}");
        }

        public void DisplayChange() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defense: {Defense}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Agility: {Agility} (+{Increase})");
            Console.WriteLine($"Move Speed: {MoveSpeed}");
        }
    }
}
