using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace BSMSClient
{
    public partial class AddBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference2.Service2Client client2 = new ServiceReference2.Service2Client();
        
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            ServiceReference2.Book book = new ServiceReference2.Book();
            if (fileUpload.HasFile)
            {
                string fileName = Path.GetFileName(fileUpload.FileName);

                string imagePath = @"C:\Users\EQ0132\source\repos\BSMS\BSMSClient\BSMSClient\Assets\Images\" + fileName;

                fileUpload.SaveAs(imagePath);

                //uploadedImage.Visible = true;
               // uploadedImage.ImageUrl = "~/Assets/Images/" + fileName;

                book.title = txttitle.Value;
                book.Language = txtlanguage.Value;
                book.Description = txtdescription.Value;
                book.Image = File.ReadAllBytes(imagePath);
                book.publication_year = txtpublication_year.Value;
                book.Price = Int32.Parse(txtPrice.Value);
                book.Status = txtstatus.Value;
                book.Edition = txtedition.Value;
                book.Genre = txtGenre.Value;

                bool isInserted = false;
                isInserted = client2.Insert(book);

                if (isInserted)
                {
                    insertLabel.Text = "Record Inserted Successfully.";
                }
            }
            else
            {
                insertLabel.Text = "Please select an image file.";
            }
        }

    }
}