using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDSpellbook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Spells allSpells = null;
        List<Spell> currentSpells = new List<Spell>();
        Spell currentSpell = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load up the Search boxes
            SchoolSearchcbo.Items.Add("Abjuration");
            SchoolSearchcbo.Items.Add("Alteration");
            SchoolSearchcbo.Items.Add("Conjuration");
            SchoolSearchcbo.Items.Add("Divination");
            SchoolSearchcbo.Items.Add("Evocation");
            SchoolSearchcbo.Items.Add("Illusion");
            SchoolSearchcbo.Items.Add("Necromancy");
            SchoolSearchcbo.Items.Add("Enchantment");

            LevelSearchcbo.Items.Add("1");
            LevelSearchcbo.Items.Add("2");
            LevelSearchcbo.Items.Add("3");
            LevelSearchcbo.Items.Add("4");
            LevelSearchcbo.Items.Add("5");
            LevelSearchcbo.Items.Add("6");
            LevelSearchcbo.Items.Add("7");

            ClassSearchcbo.Items.Add("Priest");
            ClassSearchcbo.Items.Add("Wizard");

            //Load up spell lists
            allSpells = new Spells();

            currentSpells = allSpells.GetAllSpells();

            ShowSpells(currentSpells);

        }

        private void ShowSpells(List<Spell> spells)
        {

            Spelllst.Items.Clear();


            foreach (Spell s in spells)
            {
                Spelllst.Items.Add(s);
            }

        }

        private void Spelllst_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Pick the Spell to see a description
            currentSpell = (Spell)Spelllst.SelectedItem;

            if (currentSpell != null)
            {

                SpellNametxt.Text = currentSpell.SpellName;
                SpellLeveltxt.Text = Convert.ToString(currentSpell.SpellLevel);
                Componentstxt.Text = currentSpell.Components;
                SpellRangetxt.Text = currentSpell.SpellRange;
                AOEtxt.Text = currentSpell.AreaOfEffect;
                SpellSavetxt.Text = currentSpell.SpellSave;
                SpellCastTimetxt.Text = currentSpell.CastingTime;
                SpellDurationtxt.Text = currentSpell.Duration;
                Classtxt.Text = currentSpell.SpellClass;
                Schooltxt.Text = currentSpell.SpellSchool;
                Booktxt.Text = currentSpell.Book;
                Descriptiontxt.Text = currentSpell.Description;

            }

        }

        private void Search(object sender, EventArgs e)
        {
            string searchName;
            string searchSchool;
            string searchClass;
            int searchLevel;

            allSpells = new Spells();
            List<Spell> searchSpells = new List<Spell>();

            if (NameSearchcbo.Text != "" )
            {
                searchName = NameSearchcbo.Text;

            }
            else
            {
                searchName = "";
            }

            if (SchoolSearchcbo.SelectedItem != null)
            {
                searchSchool = (string)SchoolSearchcbo.SelectedItem;
            }
            else
            {
                searchSchool = "";
            }

            if (ClassSearchcbo.SelectedItem != null)
            {
                searchClass = (string)ClassSearchcbo.SelectedItem;
            }
            else
            {
                searchClass = "";
            }

            if (LevelSearchcbo.SelectedItem != null)
            {
                searchLevel = Convert.ToInt16(LevelSearchcbo.SelectedItem);

                searchSpells = currentSpells.FindAll(x => x.SpellName.Contains(searchName));

                searchSpells = searchSpells.FindAll(x => x.SpellSchool.Contains(searchSchool));

                searchSpells = searchSpells.FindAll(x => x.SpellClass.Contains(searchClass));

                searchSpells = searchSpells.FindAll(x => x.SpellLevel.Equals(searchLevel));
            }
            else
            {
                //searchLevel = "";
                searchSpells = currentSpells.FindAll(x => x.SpellName.Contains(searchName));

                searchSpells = searchSpells.FindAll(x => x.SpellSchool.Contains(searchSchool));

                searchSpells = searchSpells.FindAll(x => x.SpellClass.Contains(searchClass));
            }

            //searchSpells = currentSpells.FindAll(x => x.SpellName.Contains(searchName));

            //searchSpells = searchSpells.FindAll(x => x.SpellSchool.Contains(searchSchool));

            //searchSpells = searchSpells.FindAll(x => x.SpellClass.Contains(searchClass));

            //searchSpells = searchSpells.FindAll(x => x.SpellLevel.Equals(searchLevel));

            ShowSpells(searchSpells);
        }
    }
}
