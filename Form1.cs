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
        Spell updateSpell = null;

        List<String> schoolList = new List<String>();
        List<String> classList = new List<String>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Load up the Search boxes

            schoolList = SpellDA.GetSchoolsSQL();

            foreach (string school in schoolList)
            {
                SchoolSearchcbo.Items.Add(school);
            }

            for (int i = 1; i < 8; i++)
            {
                LevelSearchcbo.Items.Add(i);
            }

            classList = SpellDA.GetClassSQL();

            foreach (string spellClass in classList)
            {
                ClassSearchcbo.Items.Add(spellClass);
            }

            //Load up spell lists
            allSpells = new Spells();

            currentSpells = allSpells.GetAllSpells();

            foreach (Spell spell in currentSpells)
            {
                SpellDA.GetSchoolsListSQL(spell);
                SpellDA.GetBookListSQL(spell);
            }

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
                Schooltxt.Clear();
                Booktxt.Clear();

                SpellNametxt.Text = currentSpell.SpellName;
                SpellLeveltxt.Text = Convert.ToString(currentSpell.SpellLevel);
                Componentstxt.Text = currentSpell.Components;
                SpellRangetxt.Text = currentSpell.SpellRange;
                AOEtxt.Text = currentSpell.AreaOfEffect;
                SpellSavetxt.Text = currentSpell.SpellSave;
                SpellCastTimetxt.Text = currentSpell.CastingTime;
                SpellDurationtxt.Text = currentSpell.Duration;
                Classtxt.Text = currentSpell.SpellClass;

                foreach (string s in currentSpell.SpellSchool)
                {
                    Schooltxt.Text += s + Environment.NewLine;
                }

                foreach (string s in currentSpell.Book)
                {
                    Booktxt.Text += s + Environment.NewLine;
                }
                //Schooltxt.Text = currentSpell.SpellSchool;
                //Booktxt.Text = currentSpell.Book;
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

            if (NameSearchcbo.Text != "")
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

        private void button1_Click(object sender, EventArgs e)
        {
            updateSpell = (Spell)Spelllst.SelectedItem;

            if (updateSpell != null)
            {

                updateSpell.SpellName = SpellNametxt.Text;
                updateSpell.SpellLevel = Convert.ToInt32(SpellLeveltxt.Text);
                updateSpell.Components = Componentstxt.Text;
                updateSpell.SpellRange = SpellRangetxt.Text;
                updateSpell.AreaOfEffect = AOEtxt.Text;
                updateSpell.SpellSave = SpellSavetxt.Text;
                updateSpell.CastingTime = SpellCastTimetxt.Text;
                updateSpell.Duration = SpellDurationtxt.Text;
                updateSpell.SpellClass = Classtxt.Text;

                if (updateSpell.SpellClass == "Wizard") 
                {
                    updateSpell.SpellClass = "1";
                } else 
                {
                    updateSpell.SpellClass = "2";
                }

                updateSpell.Description = Descriptiontxt.Text;

                updateSpell.Reversible = false;

                //updateSpell.SpellSchool = 

                //foreach (string s in currentSpell.SpellSchool)
                //{
                //    Schooltxt.Text += s + Environment.NewLine;
                //}

                //foreach (string s in currentSpell.Book)
                //{
                //    Booktxt.Text += s + Environment.NewLine;
                //}

                SpellDA.UpdateSpellSQL(updateSpell);
            }
        }
    }
}
