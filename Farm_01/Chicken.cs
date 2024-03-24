using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_01
{
    public class Chicken : Animal
    {
        public const int defaultEggsProductionPerDay = 1;
        public const string type = "chicken";
        public const string defaultProduct = "eggs";

        public int EggsProductionPerDay { get; set; }
        public Chicken(int id, string type, int eggsProductionPerDay) : base(type)
        {
            EggsProductionPerDay = eggsProductionPerDay;
        }
        public Chicken() : base(type)
        {
            EggsProductionPerDay = defaultEggsProductionPerDay;
            Product = defaultProduct;
        }

        public override void AddAnimal()
        {
            base.AddAnimalToBaseTable();

            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            connection.Open();
            
            string query = "INSERT INTO chickens (chicken_id, eggs_production) VALUES (@chickenId, @eggsProduction);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@chickenId", this.Id);
            command.Parameters.AddWithValue("@eggsProduction", this.EggsProductionPerDay);

            connection.Close();
        }

        public override void DeleteAnimal()
        {
            DeleteAnimalFromBaseTable();
        }

        public override void AddProduct()
        {
            AddProductToBaseTable();
        }

        public override void DeleteProduct()
        {
            DeleteProductFromBaseTable();
        }
    }
}
