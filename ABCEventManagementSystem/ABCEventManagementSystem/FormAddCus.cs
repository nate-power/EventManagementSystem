using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCEventManagementSystem
{
    public partial class FormAddCus : Form
    {
        private EventCoordinator currentCoord;
        
        public FormAddCus(EventCoordinator eCoord)
        {            
            InitializeComponent();
            currentCoord = eCoord;
        }

        private void FormAddCus_Load(object sender, EventArgs e)
        {
            // allow user to enter info right on form load without clicking the field
            textBoxFirst.Focus();
        }

        public void btnSubmit_Click(object sender, EventArgs e)
        {            
            textBoxFirst.Focus();
            lblMessage.ForeColor = System.Drawing.Color.Maroon;            
            if (textBoxFirst.Text == "" || textBoxLast.Text == "" || textBoxPhone.Text == "")
            {                
                lblMessage.Text = "Please fill in information";
            }
            else
            {
                if (textBoxFirst.Text.IndexOfAny("0123456789".ToCharArray()) == -1 && textBoxLast.Text.IndexOfAny("0123456789".ToCharArray()) == -1 && textBoxPhone.Text.IndexOfAny("0123456789".ToCharArray()) != -1)
                {
                    // correct information will add a new customer
                    lblMessage.Text = "";
                    string fname = textBoxFirst.Text.Trim();
                    string lname = textBoxLast.Text.Trim();
                    string phone = textBoxPhone.Text.Trim();
                    if (currentCoord.addCustomer(fname, lname, phone))
                    {
                        lblMessage.ForeColor = System.Drawing.Color.Black;
                        lblMessage.Text = "Customer Added Succesfully";
                        textBoxFirst.Text = "";
                        textBoxLast.Text = "";
                        textBoxPhone.Text = "";
                    }
                    else
                    {
                        lblMessage.Text = "Customer Not Added";
                    }
                }
                else if (textBoxFirst.Text.IndexOfAny("0123456789".ToCharArray()) != -1 || textBoxLast.Text.IndexOfAny("0123456789".ToCharArray()) != -1)
                {                   
                    lblMessage.Text = "Customer Not Added - First and Last name cannot contain numbers";
                }
                else if (textBoxPhone.Text.IndexOfAny("0123456789".ToCharArray()) == -1)
                {
                    lblMessage.Text = "Customer not Added - Phone Number must have no letters";
                }

                else
                {
                    lblMessage.Text = "Customer Not Added";
                }
            }           
        }        
    }
}
