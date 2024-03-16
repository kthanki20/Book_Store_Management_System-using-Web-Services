using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BSMSClient
{
    public partial class UpdateOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ServiceReference3.Service3Client client3 = new ServiceReference3.Service3Client();
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            ServiceReference3.Order order = new ServiceReference3.Order();
            if (fileUpload.HasFile)
            {
                string fileName = Path.GetFileName(fileUpload.FileName);

                string imagePath = @"C:\Users\EQ0132\source\repos\BSMS\BSMSClient\BSMSClient\Assets\Images\" + fileName;

                fileUpload.SaveAs(imagePath);

                order.id = Int32.Parse(txtid.Value);
                order.order_date = DateTime.Now;
                order.book_id = Int32.Parse(txtbid.Value);
                order.price = Int32.Parse(txtprice.Value);
                order.Image = File.ReadAllBytes(imagePath);
                bool isInserted = false;
                isInserted = client3.Update(order);

                if (isInserted)
                {
                    insertLabel.Text = "Record Updated Successfully.";
                }
            }
            else
            {
                insertLabel.Text = "Please select an image file.";
            }

        }
    }
}