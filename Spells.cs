using System;
using System.Collections.Generic;
using System.Text;

namespace DnDSpellbook
{
    class Spells
    {

        List<Spell> spells = new List<Spell>();

        public Spells() { }

        public List<Spell> GetAllSpells()
        {
            spells = SpellDA.GetSpellsXML();

            return spells;
        }

    }
}
