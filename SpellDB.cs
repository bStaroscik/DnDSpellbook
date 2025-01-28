using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDSpellbook
{
    public class SpellDB
    {
        public static SqlConnection GetConnection()
        {
            // this is the school connection
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=2ndEdDnDSpells;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            // this is the home connection
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=N:\1434\Fall2021\ParkingApp\ParkingData.mdf;Integrated Security=True";

            SqlConnection connection = new SqlConnection(connectionString);
            return connection;

        }
    }
}
