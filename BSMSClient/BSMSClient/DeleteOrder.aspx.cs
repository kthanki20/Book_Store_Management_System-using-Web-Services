using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BSMSClient
{
    public partial class DeleteOrder : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        ServiceReference3.Service3Client client3 = new ServiceReference3.Service3Client();
        protected void btnSignUp_Click(object sender, EventArgs e)
        {
            ServiceReference3.Order order = new ServiceReference3.Order();

            int oid = Int32.Parse(txtOid.Value);
            bool isDeleted = false;
            isDeleted = client3.Delete(oid);

            if (isDeleted == true)
            {
                insertLabel.Text = "Record Deleted Successfully.";

                txtOid.Value = "";
            }
        }
    }
}