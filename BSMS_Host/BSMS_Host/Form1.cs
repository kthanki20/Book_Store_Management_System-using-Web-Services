using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSMS_Host
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceHost serviceHost = new ServiceHost(typeof(Book_Store_Management_System.Service1));

            serviceHost.Open();


            ServiceHost serviceHost1 = new ServiceHost(typeof(Book_Store_Management_System.Service2));

            serviceHost1.Open();

            ServiceHost serviceHost2 = new ServiceHost(typeof(Book_Store_Management_System.Service3));

            serviceHost2.Open();

            ServiceHost serviceHost3 = new ServiceHost(typeof(Book_Store_Management_System.Service4));

            serviceHost3.Open();

            label1.Text = "Server Running...";

        }
    }
}
