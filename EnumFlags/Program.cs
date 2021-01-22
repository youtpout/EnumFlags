using System;
using System.Collections.Generic;

namespace EnumFlags
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Spell> spells = new List<Spell>();
            Spell spell1 = new Spell("Feu magic", SpellTypeEnum.Feu | SpellTypeEnum.Magic);
            Spell spell2 = new Spell("Eau physic", SpellTypeEnum.Eau | SpellTypeEnum.Physic);
            Spell spell3 = new Spell("Eau", SpellTypeEnum.Eau);
            Spell spell4 = new Spell("Vent", SpellTypeEnum.Eau | SpellTypeEnum.Feu);
            spells.Add(spell1);
            spells.Add(spell2);
            spells.Add(spell3);
            spells.Add(spell4);

            foreach (var item in spells)
            {
                Console.WriteLine($"Pour le sort {item.Name} nous avons : ");
                if ((item.SpellType & SpellTypeEnum.Eau) == SpellTypeEnum.Eau)
                {
                    Console.Write("de l'eau ");
                }
                if ((item.SpellType & SpellTypeEnum.Feu) == SpellTypeEnum.Feu)
                {
                    Console.Write("du feu ");
                }
                if ((item.SpellType & SpellTypeEnum.Physic) == SpellTypeEnum.Physic)
                {
                    Console.Write("des dégats physiques ");
                }
                if ((item.SpellType & SpellTypeEnum.Magic) == SpellTypeEnum.Magic)
                {
                    Console.Write("des dégats magiques ");
                }
                Console.WriteLine();

            }

            Console.ReadKey();
        }
    }

    [Flags]
    public enum SpellTypeEnum
    {
        Nothing = 0,
        Magic = 1,
        Physic = 2,
        Eau = 4,
        Feu = 8
    }

    public class Spell
    {
        public string Name { get; set; }
        public SpellTypeEnum SpellType { get; set; }

        public Spell() { }

        public Spell(string name, SpellTypeEnum spellType)
        {
            this.Name = name;
            this.SpellType = spellType;
        }
    }
}
