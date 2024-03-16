using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Book_Store_Management_System
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service2 : IService2
    {

        public bool Insert(Book book)
        {
            bool isInserted = false;

            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BankManagement; Integrated Security = True;Connect Timeout=30");
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Book] (title, Language, Description, publication_year, Price, Image, Status, Edition, Genre) VALUES (@title, @Language, @Description, @publication_year, @Price, @Image, @Status, @Edition, @Genre)", connection);
            cmd.Parameters.AddWithValue("@title", book.title);
            cmd.Parameters.AddWithValue("@Language", book.Language);
            cmd.Parameters.AddWithValue("@Description", book.Description);
            cmd.Parameters.AddWithValue("@publication_year", book.publication_year);
            cmd.Parameters.AddWithValue("@Price", book.Price);
            cmd.Parameters.AddWithValue("@Image", book.Image);
            cmd.Parameters.AddWithValue("@Status", book.Status);
            cmd.Parameters.AddWithValue("@Edition", book.Edition);
            cmd.Parameters.AddWithValue("@Genre", book.Genre);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                isInserted = true;
            }


            return isInserted;

        }

        public bool Update(Book book)
        {
            bool IsUpdated = false;

            using (SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BankManagement; Integrated Security = True;Connect Timeout=30"))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("UPDATE [Book] SET title=@title,Language=@Language,Description=@Description,publication_year=@publication_year,Price=@Price,Image=@Image,Status=@Status,Edition=@Edition,Genre=@Genre WHERE title=@title", connection);


                cmd.Parameters.AddWithValue("@title", book.title);
                cmd.Parameters.AddWithValue("@Language", book.Language);
                cmd.Parameters.AddWithValue("@Description", book.Description);
                cmd.Parameters.AddWithValue("@publication_year", book.publication_year);
                cmd.Parameters.AddWithValue("@Price", book.Price);
                cmd.Parameters.AddWithValue("@Image", book.Image);
                cmd.Parameters.AddWithValue("@Status", book.Status);
                cmd.Parameters.AddWithValue("@Edition", book.Edition);
                cmd.Parameters.AddWithValue("@Genre", book.Genre);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    IsUpdated = true;
                }
            }

            return IsUpdated;

        }
        public bool Delete(string title)
        {
            bool IsDeleted = false;

            using (SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BankManagement; Integrated Security = True;Connect Timeout=30"))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM [Book] WHERE title=@title", connection);

                cmd.Parameters.AddWithValue("@title", title);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    IsDeleted = true;
                }
            }
            return IsDeleted;
        }

        
    }
}
