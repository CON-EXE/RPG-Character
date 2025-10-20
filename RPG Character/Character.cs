namespace RPG_Character {
    public class Character : ICharacter {
        public string Name { get; set; }
        public int Health { get; set; } = 100;
        public int Attack { get; set; } = 20;
        public int Defense { get; set; } = 20;
        public int Intelligence { get; set; } = 20;
        public int Agility { get; set; } = 20;
        public int MoveSpeed { get; set; } = 20;
        public int Level { get; set; } = 1;

        public Character(string name) {
            Name = name;
        }

        public void DisplayInfo() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Health: {Health}");
            Console.WriteLine($"Attack: {Attack}");
            Console.WriteLine($"Defense: {Defense}");
            Console.WriteLine($"Intelligence: {Intelligence}");
            Console.WriteLine($"Agility: {Agility}");
            Console.WriteLine($"Move Speed: {MoveSpeed}");
        }

        public void LevelUp() {
            Level++;

            bool selected = false;
                Console.WriteLine("You Leveled up!");
                Console.WriteLine("1. Health");
                Console.WriteLine("2. Attack");
                Console.WriteLine("3. Defense");
                Console.WriteLine("4. Intelligence");
                Console.WriteLine("5. Agility");
                Console.WriteLine("6. Move Speed");
            while(!selected) {
                Console.Write("Select a stat to increase: ");
                string input = Console.ReadLine();

                switch (input) {
                    case "1":
                        Health += 2;
                        Console.WriteLine("Health +2");
                        selected = true;
                        break;
                    case "2":
                        Attack += 2;
                        Console.WriteLine("Attack +2");
                        selected = true;
                        break;
                    case "3":
                        Defense += 2;
                        Console.WriteLine("Defense +2");
                        selected = true;
                        break;
                    case "4":
                        Intelligence += 2;
                        Console.WriteLine("Intelligence +2");
                        selected = true;
                        break;
                    case "5":
                        Agility += 2;
                        Console.WriteLine("Agility +2");
                        selected = true;
                        break;
                    case "6":
                        MoveSpeed += 2;
                        Console.WriteLine("Move Speed +2");
                        selected = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
        }
    }
}
