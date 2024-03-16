using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Book_Store_Management_System
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service1 : IService1
    {
     

        public bool Insert(Register user)
        {
            bool isInserted = false;

            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BankManagement; Integrated Security = True;Connect Timeout=30") ;
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [User] (first_name, last_name, Email, Password, Address, Zip_code, phoneNumber, DOB, Role) VALUES (@first_name, @last_name, @Email, @Password, @Address, @Zip_code, @phoneNumber, @DOB, @Role)", connection);
            cmd.Parameters.AddWithValue("@first_name", user.first_name);
            cmd.Parameters.AddWithValue("@last_name", user.last_name);
            cmd.Parameters.AddWithValue("@Email", user.Email);
            cmd.Parameters.AddWithValue("@Password",user.Password);
            cmd.Parameters.AddWithValue("@Address", user.Address);
            cmd.Parameters.AddWithValue("@Zip_code", user.Zip_code);
            cmd.Parameters.AddWithValue("@phoneNumber",user.phoneNumber);
            cmd.Parameters.AddWithValue("@DOB", user.DOB);
            cmd.Parameters.AddWithValue("@Role",user.Role);

            //  if Record Successfully Inserted then it returns 1
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                isInserted = true;
            }

           // connection.Close();

            return isInserted;

           
        }

        public bool Update(Register user)
        {
            bool IsUpdated = false;

            using (SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BankManagement; Integrated Security = True;Connect Timeout=30"))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("UPDATE [User] SET first_name=@first_name,last_name=@last_name,Email=@Email,Password=@Password,Address=@Address,Zip_code=@Zip_code,phoneNumber=@phoneNumber,@DOB= DOB,Role=@Role WHERE Email=@Email", connection);

                cmd.Parameters.AddWithValue("@first_name", user.first_name);
                cmd.Parameters.AddWithValue("@last_name", user.last_name);
                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", user.Password);
                cmd.Parameters.AddWithValue("@Address", user.Address);
                cmd.Parameters.AddWithValue("@Zip_code", user.Zip_code);
                cmd.Parameters.AddWithValue("@phoneNumber", user.phoneNumber);
                cmd.Parameters.AddWithValue("@DOB", user.DOB);
                cmd.Parameters.AddWithValue("@Role", user.Role);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    IsUpdated = true;
                }
            }

            return IsUpdated;
        }

        public bool Delete(string email)
        {
            bool IsDeleted = false;

            using (SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BankManagement; Integrated Security = True;Connect Timeout=30"))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM [User] WHERE Email=@Email", connection);

                cmd.Parameters.AddWithValue("@Email", email);

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    IsDeleted = true;
                }
            }

            return IsDeleted;
        }

        public bool login(string username, string password)
        {
            bool islogged = false;
            string pass = "";
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BankManagement;Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();

                    SqlCommand cmd = new SqlCommand("SELECT Password FROM [User] WHERE Email=@username", connection);
                    cmd.Parameters.AddWithValue("@username", username);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pass = reader.GetString(0); // Assuming title is of type string
                        }
                    }
                }
                if (pass == password)
                {
                    islogged = true;
                   
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

            return islogged;
        }
    }
}
