namespace RPG_Character {
    public class GameWorld {
        public Character Player { get; set; }

        public void CreateCharacter() {
            if (Player == null) {
                string name = "";
                
                while(name == "") { 
                    Console.Write("Enter Player name: ");
                    name = Console.ReadLine();
                    if(name == "") {
                        Console.WriteLine("Name cannot be empty");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                Player = new Character(name);
            }
        }
    }
}
