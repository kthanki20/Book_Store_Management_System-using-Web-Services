using BSMSClient.ServiceReference2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BSMSClient
{
    public partial class OrderBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BindBooksToDropdown();
        }

        ServiceReference3.Service3Client client3 = new ServiceReference3.Service3Client();
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            ServiceReference3.Order order = new ServiceReference3.Order();

            
            if (fileUpload.HasFile)
            {
                string fileName = Path.GetFileName(fileUpload.FileName);
                string email = txtid.Value;

                
                string imagePath = @"C:\Users\EQ0132\source\repos\BSMS\BSMSClient\BSMSClient\Assets\Images\" + fileName;

                fileUpload.SaveAs(imagePath);
                string selectedValue = ddlBooks.SelectedValue;

                
                string[] parts = selectedValue.Split('-');

                if (parts.Length == 2)
                {
                    // Extract the integer part (ID)
                    if (int.TryParse(parts[0].Trim(), out int bookId))
                    {
                        order.id = client3.FetchId(email);
                        order.order_date = DateTime.Now;
                        order.book_id = bookId;
                        order.price = Int32.Parse(txtprice.Value);
                        order.Image = File.ReadAllBytes(imagePath);

                        bool isInserted = false;
                        isInserted = client3.Insert(order);

                        if (isInserted)
                        {
                            insertLabel.Text = "Record Inserted Successfully.";
                            Response.Redirect("DoPayment.aspx");
                        }
                    }
                 }
             }
               
            else
            {
                insertLabel.Text = "Please select an image file.";
            }

        }

        private void BindBooksToDropdown()
        {
            if (!IsPostBack)
            {   
                Dictionary<int, string> books = client3.FetchBooks();

                // Modify the book titles to include both the integer and string content
                var bookTitles = books.Select(kvp => $"{kvp.Key} - {kvp.Value}").ToList();

                // Now you have the modified list of book titles, you can bind it to your dropdown list
                ddlBooks.DataSource = bookTitles;
                ddlBooks.DataBind();

                // Optionally, you can add a default item to the dropdown list
                ddlBooks.Items.Insert(0, new ListItem("Select a Book", ""));
            }
        }

    }
}