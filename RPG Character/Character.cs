namespace RPG_Character {
    public class Character : ICharacter {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int Attack { get; set; } = 20;
        public int Defense { get; set; } = 20;
        public int Intelligence { get; set; } = 20;
        public int Agility { get; set; } = 20;
        public int MoveSpeed { get; set; } = 20;

        public Character(string name) {
            Name = name;
        }

        public void DisplayInfo() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defense: {Defense}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Agility: {Agility}");
            Console.WriteLine($"Move Speed: {MoveSpeed}");
        }
    }
}
