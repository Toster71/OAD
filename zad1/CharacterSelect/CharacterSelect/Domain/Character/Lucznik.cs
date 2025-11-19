using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Lucznik : Entity.Character
{
    public Lucznik(string name) : base(name, CharacterClass.Lucznik)
    {
        Health = 90;
        Strength = 7;
        Intelligence = 10;
        Agility = 14;
        Luck = 10;
        Charisma = 10;
    }
}