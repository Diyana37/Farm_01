using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_01
{
    public class Sheep : Animal
    {
        public const double defaultWoolProductionPerDay = 0.05;
        public const string type = "sheep";
        public const string defaultProduct = "wool";

        public double WoolProductionPerDay { get; set; }
        public Sheep(int id, string type, int woolProductionPerDay) : base(type)
        {
            WoolProductionPerDay = woolProductionPerDay;
        }
        public Sheep() : base(type)
        {
            WoolProductionPerDay = defaultWoolProductionPerDay;
            Product = defaultProduct;
        }

        public override void AddAnimal()
        {
            base.AddAnimalToBaseTable();

            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO sheep (sheep_id, wool_production) VALUES (@sheepId, @woolProduction);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@sheepId", this.Id);
            command.Parameters.AddWithValue("@woolProduction", this.WoolProductionPerDay);

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
