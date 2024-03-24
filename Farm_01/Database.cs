using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_01
{
    public class Database
    {
        private const string connectionString = @"Data Source=DIYANA\SQLEXPRESS;Initial Catalog=farm;Integrated Security=true;User ID=farm;Password=12345678";

        public Dictionary<string, int> GetAnimals()
        {
            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT animal_type, COUNT(animal_type) FROM animals GROUP BY animal_type;\r\n";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            Dictionary<string, int> counts = new Dictionary<string, int>();
            while (reader.Read())
            {
                string animalType = reader.GetString(0);
                int count = reader.GetInt32(1);
                counts.Add(animalType, count);
            }

            connection.Close();
            return counts;
        }
    }
}
