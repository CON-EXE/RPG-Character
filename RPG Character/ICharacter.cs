namespace RPG_Character {
    public interface ICharacter {
        string Name { get; }
        int Health { get; }
        int Attack { get; }
        int Defense { get; }
        int Intelligence { get; }
        int Agility { get; }
        int MoveSpeed { get; }
        int Level { get; }
        void DisplayInfo();
        void LevelUp();
    }
}
