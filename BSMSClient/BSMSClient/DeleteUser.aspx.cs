using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BSMSClient
{
    public partial class DeleteUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            ServiceReference1.Register user = new ServiceReference1.Register();
            user.Email = txtName.Value;
            string mail = txtName.Value;

            bool isDeleted = false;
            isDeleted = client.Delete(mail);

            if (isDeleted == true)
            {
                insertLabel.Text = "Record Deleted Successfully.";

                txtName.Value = ""; 
            }

        }
    }
}