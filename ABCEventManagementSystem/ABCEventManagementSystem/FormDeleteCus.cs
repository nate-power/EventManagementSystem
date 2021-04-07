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
    public partial class FormDeleteCus : Form
    {
        private EventCoordinator currentCoord;

        public FormDeleteCus(EventCoordinator eCoord)
        {
            currentCoord = eCoord;
            InitializeComponent();
        }

        private void FormDeleteCus_Load(object sender, EventArgs e)
        {
            // set initial view for user
            textBoxId.Text = "";
            labelBookings.Text = "";
            labelBookingsInfo.Text = "";
            btnShowCustomers.Hide();
            textBoxId.Show();
            labelCusId.Show();
            btnSubmit.Show();
            textBoxId.Focus();
            lblMessage.Text = "No Customers Available";
            lblMessage.Show();
            btnConfirm.Hide();
            btnDeny.Hide();
            clearCustomers();
            if (currentCoord.customerList()[0] != null && currentCoord.customerList()[0] != "")
            {
                // used to view all customers in the customer list
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

        private void clearCustomers()
        {
            labelNumberInfo.Text = "";
            labelNameInfo.Text = "";
            labelPhoneInfo.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnShowCustomers.Show();
            lblMessage.Show();
            clearCustomers();
            int id;
            if (int.TryParse(textBoxId.Text, out id))
            {                                
                if (currentCoord.customerExists(id))
                {
                    // change to customer view for deletion confirmation
                    string customer = currentCoord.getCustomerInfoById(id);
                    labelBookings.Text = "Bookings";
                    string[] customerFields = customer.Split(';');
                    labelNumberInfo.Text = customerFields[0];
                    labelNameInfo.Text = customerFields[1];
                    labelPhoneInfo.Text = customerFields[2];
                    labelBookingsInfo.Text = customerFields[3];
                    lblMessage.Text = "Are you sure you want to delete customer with ID " + id + "?";
                    btnConfirm.Show();
                    btnDeny.Show();
                    textBoxId.Hide();
                    labelCusId.Hide();
                    btnSubmit.Hide();
                }
                else
                {                    
                    lblMessage.Text = "Customer with ID " + id + " was not found..";
                }
            }
            else
            {
                lblMessage.Text = "Invalid input for ID search";
            }
        }

        private void btnShowCustomers_Click(object sender, EventArgs e)
        {   
            // used to bring user back to initial delete customer page
            FormDeleteCus_Load(sender, e);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            currentCoord.deleteCustomer(id);
            btnConfirm.Hide();
            btnDeny.Hide();
            lblMessage.Text = "Customer with ID " + id + " was successfully deleted";            
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            FormDeleteCus_Load(sender, e);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
