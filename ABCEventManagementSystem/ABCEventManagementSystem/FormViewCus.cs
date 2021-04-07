using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCEventManagementSystem
{
    public partial class FormViewCus : Form
    {
        private EventCoordinator currentCoord;

        public FormViewCus(EventCoordinator eCoord)
        {
            InitializeComponent();
            currentCoord = eCoord;
        }

        private void FormViewCus_Load(object sender, EventArgs e)
        {
            lblMessage.Show();
            if (currentCoord.customerList()[0] != null && currentCoord.customerList()[0] != "")
            {
                //view a list of all customers
                foreach (string customer in currentCoord.customerList())
                {
                    if (customer != "")
                    {
                        lblMessage.Hide();
                        string[] customerFields = customer.Split(';');
                        labelNumberInfo.Text += customerFields[0] + "\n\n";
                        labelNameInfo.Text += customerFields[1] + "\n\n";
                        labelPhoneInfo.Text += customerFields[2] + "\n\n";
                    }
                }
            }            
        }
    }
}
