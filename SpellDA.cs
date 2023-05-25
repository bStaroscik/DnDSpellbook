using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace DnDSpellbook
{
    class SpellDA
    {

        //private static string filename = "Spells.txt";
        //internal static List<Spell> GetSpells()
        //{
        //    List<Spell> allSpells = new List<Spell>();

        //    StreamReader textIn = new StreamReader(new FileStream(filename, FileMode.Open, FileAccess.Read));

        //    while (textIn.Peek() != -1)
        //    {
        //        string row = textIn.ReadLine();
        //        string[] columns = row.Split(',');
        //        Spell aSpell = new Spell(Convert.ToInt16(columns[0]), columns[1], Convert.ToInt16(columns[2]), columns[3], columns[4], columns[5], columns[6], columns[7], columns[8], columns[9], columns[10], columns[11], columns[12]);

        //        allSpells.Add(aSpell);

        //    }
        //    textIn.Close();

        //    return allSpells;

        //}

        //private static string xmlfilename = "C:\\Users\\User\\source\\repos\\DnDSpellbook\\Spells.xml";

        private static string xmlfilename = Path.GetFullPath("Spells.xml");
        internal static List<Spell> GetSpellsXML()
        {
            List<Spell> allSpells = new List<Spell>();

            XDocument doc = XDocument.Load(xmlfilename);
            allSpells = doc.Descendants("Spells")
                             .Elements()
                             .Select(node => new Spell()
                             {
                                 SpellId = Convert.ToInt16(node.Element("ID").Value),
                                 SpellLevel = Convert.ToInt16(node.Element("Level").Value),
                                 SpellClass = node.Element("Class").Value,
                                 SpellName = node.Element("SpellName").Value,
                                 Reversible = node.Element("Reversible").Value,
                                 SpellSchool = node.Element("School_Sphere").Value,
                                 Components = node.Element("Components").Value,
                                 SpellRange = node.Element("Range").Value,
                                 AreaOfEffect = node.Element("AreaOfEffect").Value,
                                 SpellSave = node.Element("Save").Value,
                                 CastingTime = node.Element("CastingTime").Value,
                                 Duration = node.Element("Duration").Value,
                                 Book = node.Element("Source").Value,
                                 Description = node.Element("Description").Value
                              })
                             .ToList();

            //XmlDocument doc = new XmlDocument();
            //doc.Load(xmlfilename);

            //XmlNodeList nodeList = doc.SelectNodes("/Spells/Spell");


            //foreach (XmlNode node in nodeList)
            //{
            //    Spell aSpell = new Spell();


            //        aSpell.SpellId = Convert.ToInt16(node["SpellID"].Value);
            //        aSpell.SpellName = node["Name"].Value;
            //        aSpell.SpellLevel = Convert.ToInt16(node["Level"].Value);
            //        aSpell.Components = node["Components"].Value;
            //        aSpell.SpellRange = node["Range"].Value;
            //        aSpell.AreaOfEffect = node["AreaOfEffect"].Value;
            //        aSpell.SpellSave = node["Save"].Value;
            //        aSpell.CastingTime = node["CastingTime"].Value;
            //        aSpell.Duration = node["Duration"].Value;
            //        aSpell.SpellClass = node["Class"].Value;
            //        aSpell.SpellSchool = node["School"].Value;
            //        aSpell.Book = node["Book"].Value;
            //        aSpell.Description = node["Description"].Value;
               
                

            //    allSpells.Add(aSpell);
            //}

            return allSpells;
        }
    }
}
