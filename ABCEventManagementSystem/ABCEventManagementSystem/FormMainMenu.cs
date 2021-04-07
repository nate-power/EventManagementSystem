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
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Form activeForm = null;
        static EventCoordinator eCoord;

        public FormMainMenu()
        {
            InitializeComponent();
            initialMenu();
            eCoord = new EventCoordinator(200, 1000, 101, 5000, 1000, 8000);
        }        

        private void Form1_Load(object sender, EventArgs e)
        {
            // load the Dashboard form
            openChildForm(new FormDashboard());            
        }

        private void initialMenu()
        {
            // hidess the sub menus until user clicks on header for each
            panelCusSubMenu.Visible = false;
            panelEventSubMenu.Visible = false;
            panelRsvpSubMenu.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            // alternates between hide and show
            if (!subMenu.Visible)
            {
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public void openChildForm(Form childForm)
        {
            // creates a form set to width and height of view panel and closes any active form
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ActivateButton(object btnSender)
        {
            // will make submenu option udnerlined when currently in view
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    currentButton = null;
                }
            }
        }

        private void CheckButton(Control previousBtn)
        {
            // returns all menu options back to no text decoration when they are not the current view, used in tandem with DisableButton()
            if (previousBtn.GetType() == typeof(Button))
            {
                previousBtn.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelCusSubMenu.Controls)
            {
                CheckButton(previousBtn);
            }

            foreach (Control previousBtn in panelEventSubMenu.Controls)
            {
                CheckButton(previousBtn);
            }

            foreach (Control previousBtn in panelRsvpSubMenu.Controls)
            {
                CheckButton(previousBtn);
            }
        }

        private void btnCustomers_Click_1(object sender, EventArgs e)
        {
            // creates an arrow beside sub menu option to indicate it is open and you can hide subpanel, same for event and RSVPs
            if (!panelCusSubMenu.Visible)
            {
                btnCustomers.Text += "   \u2191";
            }
            else
            {
                btnCustomers.Text = "CUSTOMERS";
            }

            showSubMenu(panelCusSubMenu);
        }

        private void btnAddCus_Click_1(object sender, EventArgs e)
        {
            // loads form to add customer
            openChildForm(new FormAddCus(eCoord));
            ActivateButton(sender);
        }

        private void btnViewCus_Click_1(object sender, EventArgs e)
        {
            // loads form to view customer
            openChildForm(new FormViewCus(eCoord));
            ActivateButton(sender);
        }

        private void btnViewCusDetails_Click_1(object sender, EventArgs e)
        {
            // loads form to view individual customer details
            openChildForm(new FormViewCusDetails(eCoord));
            ActivateButton(sender);
        }

        private void btnDelCus_Click_1(object sender, EventArgs e)
        {
            // loads form to delete customer
            openChildForm(new FormDeleteCus(eCoord));
            ActivateButton(sender);
        }

        private void btnEvents_Click_1(object sender, EventArgs e)
        {
            if (!panelEventSubMenu.Visible)
            {
                btnEvents.Text += "   \u2191";
            }
            else
            {
                btnEvents.Text = "EVENTS";
            }

            showSubMenu(panelEventSubMenu);
        }

        private void btnAddEvent_Click_1(object sender, EventArgs e)
        {
            // loads form to add event
            openChildForm(new FormAddEvent(eCoord));
            ActivateButton(sender);
        }

        private void btnViewEvents_Click_1(object sender, EventArgs e)
        {
            // loads form to view events
            openChildForm(new FormViewEvents(eCoord));
            ActivateButton(sender);
        }

        private void btnViewEventDetails_Click_1(object sender, EventArgs e)
        {
            // loads form to view specific event
            openChildForm(new FormViewEventDetails(eCoord));
            ActivateButton(sender);
        }

        private void btnDelEvent_Click(object sender, EventArgs e)
        {
            // loads form to delete events
            openChildForm(new FormDeleteEvent(eCoord));
            ActivateButton(sender);
        }

        private void btnRsvp_Click_1(object sender, EventArgs e)
        {

            if (!panelRsvpSubMenu.Visible)
            {
                btnRsvp.Text += "   \u2191";
            }
            else
            {
                btnRsvp.Text = "RSVP";
            }

            showSubMenu(panelRsvpSubMenu);
        }

        private void btnRsvpEvent_Click_1(object sender, EventArgs e)
        {
            // loads form to add RSVP
            openChildForm(new FormRsvpEvent(eCoord));
            ActivateButton(sender);
        }

        private void btnViewRsvp_Click_1(object sender, EventArgs e)
        {
            // loads form to view all RSVPs
            openChildForm(new FormViewAllRsvp(eCoord));
            ActivateButton(sender);
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            // will close the entire application
            this.Close();
        }

    }
}

