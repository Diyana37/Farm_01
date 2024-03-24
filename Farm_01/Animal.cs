using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm_01
{
    public abstract class Animal
    {
        protected const string connectionString = @"Data Source=DIYANA\SQLEXPRESS;Initial Catalog=farm;Integrated Security=true;User ID=farm;Password=12345678";
        SqlCommand command;

        public static Func<string, SqlConnection> SqlConnectionConstructor { get; set; }
        protected Animal(string type)
        {
            Type = type;
        }
        public int Id { get; set; }
        public string Type { get; set; }
        public string Product { get; set; }
        public static Dictionary<string, int> GetAnimals()
        {
            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT animal_type, COUNT(animal_type) FROM Animals GROUP BY animal_type;";
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
        public abstract void AddAnimal();

        protected void AddAnimalToBaseTable()
        {
            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO Animals (animal_type) VALUES (@animalType); SELECT CAST(scope_identity() AS int);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@animalType", this.Type);

            int modified = (int)command.ExecuteScalar();
            Id = modified;

            connection.Close();
        }
        protected void DeleteAnimalFromBaseTable()
        {
            SqlConnection connection;
            connection = new SqlConnection(connectionString);

            command = new SqlCommand("DELETE FROM Animals WHERE Id = (SELECT TOP (1) Id FROM Animals WHERE animal_type = @animalType ORDER BY Id DESC);", connection);
            connection.Open();

            command.Parameters.AddWithValue("@animalType", this.Type);
            command.ExecuteNonQuery();

            connection.Close();
        }
        public abstract void DeleteAnimal();

        public static Dictionary<string, int> GetProducts()
        {
            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "SELECT product, COUNT(product) FROM Products GROUP BY product;";

            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            Dictionary<string, int> counts = new Dictionary<string, int>();
            while (reader.Read())
            {
                string product = reader.GetString(0);
                int quantity = reader.GetInt32(1);
                counts.Add(product, quantity);
            }

            connection.Close();
            return counts;
        }

        protected void AddProductToBaseTable()
        {
            SqlConnection connection;
            connection = new SqlConnection(connectionString);
            connection.Open();

            string query = "INSERT INTO Products (product) VALUES (@product); SELECT CAST(scope_identity() AS int);";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@product", this.Product);

            int modified = (int)command.ExecuteScalar();
            Id = modified;

            connection.Close();
        }
        public abstract void AddProduct();

        protected void DeleteProductFromBaseTable()
        {
            SqlConnection connection;
            connection = new SqlConnection(connectionString);

            command = new SqlCommand("DELETE FROM Products WHERE No = (SELECT TOP (1) No FROM " +
                "Products WHERE product = @product ORDER BY No DESC);", connection);
            connection.Open();

            command.Parameters.AddWithValue("@product", this.Product);
            command.ExecuteNonQuery();

            connection.Close();
        }
        public abstract void DeleteProduct();
    }
}
