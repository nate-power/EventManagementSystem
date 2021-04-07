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
    public partial class FormViewEventDetails : Form
    {
        private EventCoordinator currentCoord;
        public FormViewEventDetails(EventCoordinator eCoord)
        {
            currentCoord = eCoord;
            InitializeComponent();
        }

        private void FormViewEventDetails_Load(object sender, EventArgs e)
        {
            // show inital view of form
            textBoxId.Focus();
            btnShowEvents.Hide();
            labelEventTitle.Text = "Enter an event ID:";
            lblMessage.Show();
            lblMessage.Text = "No Events Available";
            labelFirstColumn.Text = "Number";
            labelSecondColumn.Text = "Event Name";
            labelThirdColumn.Text = "Venue Name";
            labelRegistered.Hide();
            labelAvailable.Hide();
            btnAttendingCus.Hide();
            labelEventTitle.Show();
            textBoxId.Show();
            btnSubmit.Show();
            clearEvents();
            if (currentCoord.eventList()[0] != null && currentCoord.eventList()[0] != "")
            {
                foreach (string events in currentCoord.eventList())
                {
                    // show a list of all events
                    if (events != "")
                    {
                        lblMessage.Hide();
                        string[] eventFields = events.Split(';');
                        labelFirstColumnInfo.Text += eventFields[0] + "\n\n";
                        labelSecondColumnInfo.Text += eventFields[1] + "\n\n";
                        labelThirdColumnInfo.Text += eventFields[2] + "\n\n";
                    }
                }
            }
        }        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            // new style of view for events if submit is clicked
            btnShowEvents.Show();
            textBoxId.Focus();
            btnShowEvents.Text = "Show All Events";
            lblMessage.Show();            
            int id;
            if (int.TryParse(textBoxId.Text, out id))
            {
                
                string events = currentCoord.getEventInfoById(id);
                if (currentCoord.eventExists(id))
                {
                    // will show new headers for event to display in depth details
                    labelEventTitle.Text = "ID: " + id;
                    labelFirstColumn.Text = "Event Name";
                    labelSecondColumn.Text = "Venue Name";
                    labelThirdColumn.Text = "Date and Time";
                    string[] eventFields = events.Split(';');
                    labelRegistered.Show();
                    labelAvailable.Show();
                    textBoxId.Hide();
                    btnSubmit.Hide();
                    btnAttendingCus.Show();
                    lblMessage.Hide();
                    labelFirstColumnInfo.Text = eventFields[1];
                    labelSecondColumnInfo.Text = eventFields[2];
                    labelThirdColumnInfo.Text = eventFields[3];
                    labelRegisteredInfo.Text = eventFields[4];
                    labelAvailablesInfo.Text = eventFields[5];
                }
                else
                {
                    clearEvents();
                    lblMessage.Text = events;
                }
            }
            else
            {
                clearEvents();
                lblMessage.Text = "Invalid input for ID search";
            }
        }

        private void btnShowEvents_Click(object sender, EventArgs e)
        {            
            if (btnShowEvents.Text == "Back to Event Details")
            {
                btnSubmit_Click(sender, e);
            }
            else 
            {                
                FormViewEventDetails_Load(sender, e);
            }
            
        }

        private void clearEvents()
        {
            labelFirstColumnInfo.Text = "";
            labelSecondColumnInfo.Text = "";
            labelThirdColumnInfo.Text = "";
            labelRegisteredInfo.Text = "";
            labelAvailablesInfo.Text = "";
        }

        private void btnAttendingCus_Click(object sender, EventArgs e)
        {
            // view for all the customers who are attending a certain event
            btnAttendingCus.Hide();
            btnShowEvents.Text = "Back to Event Details";
            labelFirstColumn.Text = "Number";
            labelSecondColumn.Text = "Customer Name";
            labelThirdColumn.Text = "";
            labelRegistered.Hide();
            labelAvailable.Hide();
            lblMessage.Show();
            clearEvents();            
            foreach (string attendees in currentCoord.attendeeList(Convert.ToInt32(textBoxId.Text)))
            {
                // show all customers attending event
                if (attendees != "")
                {
                    lblMessage.Text = "";
                    string[] attendeeFields = attendees.Split(';');
                    labelFirstColumnInfo.Text += attendeeFields[0] + "\n\n";
                    labelSecondColumnInfo.Text += attendeeFields[1] + "\n\n";
                    lblMessage.Hide();
                }
                else
                {
                    lblMessage.Text = "No Customers attending";
                }
            }
        }
    }
}
