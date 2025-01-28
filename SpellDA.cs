using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace DnDSpellbook
{
    public class SpellDA
    {
        internal static List<Spell> GetSpellsXML()
        {
            List<Spell> allSpells = new List<Spell>();

            //need a connection
            SqlConnection conn = SpellDB.GetConnection();


            // need a sql Statment
            string selectStatement = "Select * from Customers";

            // need a sqlCommand
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            try
            {
                //open the database
                conn.Open();
                //execute the command
                SqlDataReader reader = selectCommand.ExecuteReader();

                //if we have anything
                while (reader.Read())
                {
                    Spell s = new Spell();
                    s.SpellId = (int)reader["SpellID"];
                    s.SpellName = reader["SpellName"].ToString();
                    s.SpellLevel = (int)reader["SpellLevel"];
                    s.Components = reader["Components"].ToString();

                    s.SpellRange = reader["SpellRange"].ToString();
                    s.AreaOfEffect = reader["AreaOfEffect"].ToString();
                    s.SpellSave = reader["SpellSave"].ToString();
                    s.CastingTime = reader["theCastingTime"].ToString();
                    s.Duration = reader["theDuration"].ToString();
                    s.SpellClass = reader["spellClass"].ToString();
                    //SpellSchool = theSpellSchool;
                    //Book = theBook;
                    s.Description = reader["Description"].ToString();
                    s.Reversible = reader["Reversible"].Equals();

                    allSpells.Add(s);
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return allSpells;
        }
    }
}
