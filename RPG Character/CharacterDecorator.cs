namespace RPG_Character {
    public abstract class CharacterDecorator : ICharacter {
        protected readonly ICharacter _character;

        protected CharacterDecorator(ICharacter character) {
            _character = character;
        }

        public virtual string Name => _character.Name;
        public virtual int Health => _character.Health;
        public virtual int Attack => _character.Attack;
        public virtual int Defense => _character.Defense;
        public virtual int Intelligence => _character.Intelligence;
        public virtual int Agility => _character.Agility;
        public virtual int MoveSpeed => _character.MoveSpeed;

        public virtual void DisplayInfo() => _character.DisplayInfo();
    }
}