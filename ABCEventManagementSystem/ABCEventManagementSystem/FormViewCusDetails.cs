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
    public partial class FormViewCusDetails : Form
    {
        private EventCoordinator currentCoord;

        public FormViewCusDetails(EventCoordinator eCoord)
        {
            InitializeComponent();
            currentCoord = eCoord;
        }

        private void FormViewCusDetails_Load(object sender, EventArgs e)
        {
            // show the initial view of form
            textBoxId.Focus();
            btnShowCustomers.Hide();
            lblMessage.Show();
            lblMessage.Text = "No Customers Available";
            clearCustomers();
            if (currentCoord.customerList()[0] != null && currentCoord.customerList()[0] != "")
            {
                foreach (string customer in currentCoord.customerList())
                {
                    // show a list of all customers
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // show new style of view when submit is clicked
            textBoxId.Focus();
            btnShowCustomers.Show();
            lblMessage.Show();
            int id;
            if (int.TryParse(textBoxId.Text, out id))
            {
                string customer = currentCoord.getCustomerInfoById(id);
                if (currentCoord.customerExists(id))
                {
                    labelBookings.Text = "Bookings";
                    string[] customerFields = customer.Split(';');
                    labelNumberInfo.Text = customerFields[0];
                    labelNameInfo.Text = customerFields[1];
                    labelPhoneInfo.Text = customerFields[2];
                    labelBookingsInfo.Text = customerFields[3];
                    lblMessage.Hide();
                }
                else
                {
                    clearCustomers();
                    labelBookings.Text = "";
                    lblMessage.Text = customer;
                }
            }
            else
            {
                clearCustomers();
                lblMessage.Text = "Invalid input for ID search";
            }
            textBoxId.Text = "";
        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {     
            // bring user back to initial form view
            labelBookings.Text = "";
            FormViewCusDetails_Load(sender, e);
        }

        private void clearCustomers()
        {
            labelNumberInfo.Text = "";
            labelNameInfo.Text = "";
            labelPhoneInfo.Text = "";
            labelBookingsInfo.Text = "";
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
