using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_01
{
    public class Goat : Animal
    {
        public const double defaultMilkProductionPerDay = 2.00;
        public const string type = "goat";
        public const string defaultProduct = "milk_goat";

        public double MilkProductionPerDay { get; set; }
        public Goat(double milkProductionPerDay) : base(type)
        {
            MilkProductionPerDay = milkProductionPerDay;
        }
        public Goat() : base(type)
        {
            MilkProductionPerDay = defaultMilkProductionPerDay;
            Product = defaultProduct;
        }

        public override void AddAnimal()
        {
            base.AddAnimalToBaseTable();

            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO goats (goat_id, milk_production) VALUES (@goatId, @milkProduction);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@goatId", this.Id);
            command.Parameters.AddWithValue("@milkProduction", this.MilkProductionPerDay);

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
