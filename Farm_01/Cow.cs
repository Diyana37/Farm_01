using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_01
{
    public class Cow : Animal
    {
        public const double defaultMilkProductionPerDay = 20.00;
        public const string type = "cow";
        public const string defaultProduct = "milk_cow";


        public double MilkProductionPerDay { get; set; }
        public Cow(int id, string type, double milkProductionPerDay) : base(type)
        {
            MilkProductionPerDay = milkProductionPerDay;
        }
        public Cow() : base(type)
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

            string query = "INSERT INTO cows (cow_id, milk_production) VALUES (@cowId, @milkProduction);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@cowId", this.Id);
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
