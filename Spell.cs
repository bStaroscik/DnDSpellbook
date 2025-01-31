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

        public List<string> SpellSchool { get; set; }

        public List<string> Book { get; set; }

        public string Description { get; set; }

        public bool Reversible { get; set; }

        public Spell() { }

        public Spell(int theSpellId, string theSpellName, int theSpellLevel, string theComponents, string theSpellRange, string theAreaOfEffect, string theSpellSave, string theCastingTime, string theDuration, string theSpellClass, string theDescription, bool theReversible)
        {
            SpellId = theSpellId;
            SpellName = theSpellName;
            SpellLevel = theSpellLevel;
            Components = theComponents;
            SpellRange = theSpellRange;
            AreaOfEffect = theAreaOfEffect;
            SpellSave = theSpellSave;
            CastingTime = theCastingTime;
            Duration = theDuration;
            SpellClass = theSpellClass;
            SpellSchool = new List<string>();
            Book = new List<string>();
            //SpellSchool = theSpellSchool;
            //Book = theBook;
            Description = theDescription;
            Reversible = theReversible;
        }

        public override string ToString()
        {
            return SpellName;
        }
    }
}
