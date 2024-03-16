using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BSMSClient
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtName.Value;
            string pass = txtPassword.Value;
            if (username == "admin@gmail.com" && pass == "admin123")
            {
                Response.Redirect("AddBook.aspx");
                return;
            }

                bool islogged = false;
            islogged = client.login(username,pass);

            if (islogged) 
            {
                insertLabel.Text = "LoggedIn Successfully.";

                txtName.Value = "";
                txtPassword.Value = "";

               
                Response.Redirect("OrderBook.aspx");
                
                
            }
        }
    }
}