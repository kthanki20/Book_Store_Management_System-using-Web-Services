using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Management_System
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service3 : IService3
    {
      
        public bool Insert(Order order)
        {
            bool isInserted = false;

            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BankManagement; Integrated Security = True;Connect Timeout=30");
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Order] (id, order_date, book_id, price, Image) VALUES (@id, @order_date, @book_id, @price, @Image)", connection);
            cmd.Parameters.AddWithValue("@id", order.id);
            cmd.Parameters.AddWithValue("@order_date", order.order_date);
            cmd.Parameters.AddWithValue("@book_id", order.book_id);
            cmd.Parameters.AddWithValue("@price", order.price);
            cmd.Parameters.AddWithValue("@Image", order.Image);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                isInserted = true;
            }


            return isInserted;

        }

        public bool Update(Order order)
        {
            bool IsUpdated = false;

            using (SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BankManagement; Integrated Security = True;Connect Timeout=30"))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("UPDATE [Order] SET id=@id,order_date=@order_date,book_id=@book_id,price=@price,Image=@Image WHERE id=@id", connection);


                cmd.Parameters.AddWithValue("@id", order.id);
                cmd.Parameters.AddWithValue("@order_date", order.order_date);
                cmd.Parameters.AddWithValue("@book_id", order.book_id);
                cmd.Parameters.AddWithValue("@price", order.price);
                cmd.Parameters.AddWithValue("@Image", order.Image);


                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    IsUpdated = true;
                }
            }

            return IsUpdated;
        }

        public bool Delete(int order_id)
        {
            bool IsDeleted = false;

            using (SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BankManagement; Integrated Security = True;Connect Timeout=30"))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM [Order] WHERE order_id=@order_id", connection);

                cmd.Parameters.AddWithValue("@order_id", order_id);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    IsDeleted = true;
                }
            }
            return IsDeleted;
        }

        public Dictionary<int, string> FetchBooks()
        {
            Dictionary<int, string> books = new Dictionary<int, string>();

            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankManagement;Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT book_id, title FROM Book", connection);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int bookId = reader.GetInt32(0); // Assuming book_id is of type int
                            string title = reader.GetString(1); // Assuming title is of type string

                            books.Add(bookId, title);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return books;
        }

        public int FetchId(string username)
        {
            int Id = 0;
            try
            {

                using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankManagement;Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT id FROM [User] WHERE Email = @username", connection);
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Id = reader.GetInt32(0); // Assuming book_id is of type int

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return Id;


        }

    }
}
