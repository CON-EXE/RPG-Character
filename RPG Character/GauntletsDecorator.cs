using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPG_Character {
    public class GauntletsDecorator : CharacterDecorator {
        private int Increase = 10;

        public GauntletsDecorator(ICharacter character) : base(character) { }

        public override int Attack => _character.Attack + Increase;

        public void Preview() {
            Console.WriteLine("Titan Gauntlets");
            Console.WriteLine($"Attack +{Increase}");
        }

        public void DisplayChange() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Attack: {Attack} (+{Increase})");
            Console.WriteLine($"Defense: {Defense}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Agility: {Agility}");
            Console.WriteLine($"Move Speed: {MoveSpeed}");
        }
    }
}
