using System;
using System.Collections.Generic;
using System.Text;

namespace DnDSpellbook
{
    class Spell
    {
        public int SpellId { get; set; }

        public string SpellName { get; set; }

        public int SpellLevel { get; set; }

        public string Components { get; set; }

        public string SpellRange { get; set; }

        public string AreaOfEffect { get; set; }

        public string SpellSave { get; set; }

        public string CastingTime { get; set; }

        public string Duration { get; set; }

        public string SpellClass { get; set; }

        public string SpellSchool { get; set; }

        public string Book { get; set; }

        public string Description { get; set; }

        public string Reversible { get; set; }

        public Spell() { }

        public Spell(int theSpellId, string theSpellName, int theSpellLevel, string theComponents, string theSpellRange, string theAreadOfEffect, string theSpellSave, string theCastingTime, string theDuration, string theSpellClass, string theSpellSchool, string theBook, string theDescription, string theReversible)
        {
            SpellId = theSpellId;
            SpellName = theSpellName;
            SpellLevel = theSpellLevel;
            Components = theComponents;
            SpellRange = theSpellRange;
            AreaOfEffect = theAreadOfEffect;
            SpellSave = theSpellSave;
            CastingTime = theCastingTime;
            Duration = theDuration;
            SpellClass = theSpellClass;
            SpellSchool = theSpellSchool;
            Book = theBook;
            Description = theDescription;
            Reversible = theReversible;
        }

        public Spell(object s)
        {
        }

        public override string ToString()
        {
            return SpellName;
        }
    }
}
