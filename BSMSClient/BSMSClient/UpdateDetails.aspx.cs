using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BSMSClient
{
    public partial class UpdateDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            ServiceReference1.Register user = new ServiceReference1.Register();
            string Role = "";
            if (admin.Checked)
            {
                Role = "Admin";
            }
            else if (user1.Checked)
            {
                Role = "User";
            }

            user.first_name = txtName.Value;
            user.last_name = txtLastName.Value;
            user.Email = txtEmail.Value;
            user.Password = txtPassword.Value;
            user.Address = txtAddress.Value;
            user.Zip_code = Convert.ToInt32(txtZip_Code.Value);
            user.phoneNumber = txtPhoneNumber.Value;
            user.DOB = DOB.Value;
            user.Role = Role;


            bool isUpdated = false;
            isUpdated = client.Update(user);

            if (isUpdated == true)
            {
                insertLabel.Text = "Record Updated Successfully.";

                txtName.Value = "";
                txtLastName.Value = "";

                txtEmail.Value = "";
                txtPassword.Value = "";
                txtAddress.Value = "";
                txtZip_Code.Value = "";
                txtPhoneNumber.Value = "";
                DOB.Value = "";
                admin.Checked = false;
                user1.Checked = false;

            }
        }
    }
}