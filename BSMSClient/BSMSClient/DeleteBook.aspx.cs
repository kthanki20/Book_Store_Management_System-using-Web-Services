using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace BSMSClient
{
    public partial class DeleteBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference2.Service2Client client2 = new ServiceReference2.Service2Client();
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            ServiceReference2.Book book = new ServiceReference2.Book();
            string title = txttitle.Value;
            bool isDeleted = false;
            isDeleted = client2.Delete(title);

            if (isDeleted == true)
            {
                insertLabel.Text = "Record Deleted Successfully.";

                txttitle.Value = "";
            }
        }
    }
}