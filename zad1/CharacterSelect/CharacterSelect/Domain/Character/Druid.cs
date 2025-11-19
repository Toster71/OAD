using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Druid : Entity.Character
{
    public Druid(string name) : base(name, CharacterClass.Druid)
    {
        Health = 85;
        Strength = 9;
        Intelligence = 10;
        Agility = 14;
        Luck = 10;
        Charisma = 10;
    }
}