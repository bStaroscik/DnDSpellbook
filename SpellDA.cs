using Microsoft.Data.SqlClient;
using System;
using System.Collections;
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
        public static List<string> GetSchoolsSQL()
        {
            List<string> allSchools = new List<string>();

            SqlConnection conn = SpellDB.GetConnection();

            string selectStatement = "Select * from SpellSchool";

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
                    string schoolName = reader["SpellSchool"].ToString();

                    allSchools.Add(schoolName);
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

            return allSchools;
        }

        public static List<string> GetClassSQL()
        {
            List<string> allClass = new List<string>();

            SqlConnection conn = SpellDB.GetConnection();

            string selectStatement = "Select * from SpellClass";

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
                    string className = reader["ClassName"].ToString();

                    allClass.Add(className);
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

            return allClass;
        }

        internal static List<Spell> GetSpellsXML()
        {
            List<Spell> allSpells = new List<Spell>();

            //need a connection
            SqlConnection conn = SpellDB.GetConnection();


            // need a sql Statment
            string selectStatement = "SELECT Spells.SpellID, Spells.SpellName, Spells.SpellLevel, Spells.Components, Spells.SpellRange, Spells.AreaOfEffect, Spells.SpellSave, Spells.CastingTime, Spells.Duration, Spells.SpellDescription, Spells.Reversible, SpellClass.ClassName " +
                                     "FROM Spells " +
                                     "JOIN SpellClass ON Spells.SpellClass = SpellClass.ClassID ";

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

                    Spell s = new Spell
                    { 

                        SpellId = (int)reader["SpellID"],
                        SpellName = reader["SpellName"].ToString(),
                        SpellLevel = (int)reader["SpellLevel"],
                        Components = reader["Components"].ToString(),

                        SpellRange = reader["SpellRange"].ToString(),
                        AreaOfEffect = reader["AreaOfEffect"].ToString(),
                        SpellSave = reader["SpellSave"].ToString(),
                        CastingTime = reader["CastingTime"].ToString(),
                        Duration = reader["Duration"].ToString(),
                        SpellClass = reader["ClassName"].ToString(),
                           //SpellSchool.Add(reader["SpellSchool"].ToString()),
                            //Book = theBook;
                        Description = reader["SpellDescription"].ToString(),
                        Reversible = (bool)reader["Reversible"]

                            
                    };

                    s.SpellSchool = new List<string>();
                    s.Book = new List<string>();

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

        internal static void GetSchoolsListSQL(Spell spell)
        {
            //need a connection
            SqlConnection conn = SpellDB.GetConnection();


            // need a sql Statment
            string selectStatement = "SELECT SpellSchool.SpellSchool " +
                                     "FROM Spells " +
                                     "JOIN SpellSchools ON Spells.SpellID = SpellSchools.SpellID " +
                                     "JOIN SpellSchool ON SpellSchool.SchoolID = SpellSchools.SchoolID " +
                                     "Where Spells.SpellID = @SpellID";

            // need a sqlCommand
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            selectCommand.Parameters.AddWithValue("@SpellID", spell.SpellId);

            try
            {
                //open the database
                conn.Open();
                //execute the command
                SqlDataReader reader = selectCommand.ExecuteReader();

                //if we have anything
                while (reader.Read())
                {
                    string spellSchoolString;
                    spellSchoolString = reader["SpellSchool"].ToString();

                    spell.SpellSchool.Add(spellSchoolString);
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
        }

        internal static void GetBookListSQL(Spell spell)
        {
            //need a connection
            SqlConnection conn = SpellDB.GetConnection();


            // need a sql Statment
            string selectStatement = "SELECT Books.BookName " +
                                     "FROM Spells " +
                                     "JOIN SpellBooks ON Spells.SpellID = SpellBooks.SpellID " +
                                     "JOIN Books ON Books.BookID = SpellBooks.BookID " +
                                     "Where Spells.SpellID = @BookID";

            // need a sqlCommand
            SqlCommand selectCommand = new SqlCommand(selectStatement, conn);

            selectCommand.Parameters.AddWithValue("@BookID", spell.SpellId);

            try
            {
                //open the database
                conn.Open();
                //execute the command
                SqlDataReader reader = selectCommand.ExecuteReader();

                //if we have anything
                while (reader.Read())
                {
                    string spellBookString;
                    spellBookString = reader["BookName"].ToString();

                    spell.Book.Add(spellBookString);
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
        }
    }
}
