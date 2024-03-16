using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Book_Store_Management_System
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service4 : IService4
    {
        public bool PaymentInsert(Payment payment)
        {
            bool isInserted = false;

            SqlConnection connection = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BankManagement; Integrated Security = True;Connect Timeout=30");
            connection.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO [Payment] (id, order_id, payment_Status, payment_Method) VALUES (@id, @order_id, @payment_Status, @payment_Method)", connection);
            cmd.Parameters.AddWithValue("@id", payment.id);
            cmd.Parameters.AddWithValue("@order_id", payment.order_id);
            cmd.Parameters.AddWithValue("@payment_Status", payment.payment_Status);
            cmd.Parameters.AddWithValue("@payment_Method", payment.payment_Method);

            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                isInserted = true;
            }


            return isInserted;
        }
    }
}
