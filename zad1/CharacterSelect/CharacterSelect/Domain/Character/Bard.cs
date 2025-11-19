using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Bard : Entity.Character
{
    public Bard(string name) : base(name, CharacterClass.Bard)
    {
        Health = 85;
        Strength = 9;
        Intelligence = 10;
        Agility = 14;
        Luck = 10;
        Charisma = 10;
    }
}