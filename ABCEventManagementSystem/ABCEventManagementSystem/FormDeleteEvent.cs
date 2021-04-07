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
    public partial class FormDeleteEvent : Form
    {
        private EventCoordinator currentCoord;
        public FormDeleteEvent(EventCoordinator eCoord)
        {
            currentCoord = eCoord;
            InitializeComponent();
        }

        private void FormDeleteEvent_Load(object sender, EventArgs e)
        {
            textBoxId.Text = "";
            labelDateTime.Text = "";
            labelDateTimeInfo.Text = "";
            labelBookings.Text = "";
            labelBookingsInfo.Text = "";
            btnShowEvents.Hide();
            textBoxId.Show();
            labelEventId.Show();
            btnSubmit.Show();
            textBoxId.Focus();
            lblMessage.Text = "No Events Available";
            lblMessage.Show();
            btnConfirm.Hide();
            btnDeny.Hide();
            clearEvents();
            if (currentCoord.eventList()[0] != null && currentCoord.eventList()[0] != "")
            {
                foreach (string events in currentCoord.eventList())
                {
                    // view all events
                    if (events != "")
                    {
                        lblMessage.Hide();
                        string[] eventFields = events.Split(';');
                        labelNumberInfo.Text += eventFields[0] + "\n\n";
                        labelEventInfo.Text += eventFields[1] + "\n\n";
                        labelVenueInfo.Text += eventFields[2] + "\n\n";
                    }
                }
            }
        }

        private void clearEvents()
        {
            labelNumberInfo.Text = "";
            labelEventInfo.Text = "";
            labelVenueInfo.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            btnShowEvents.Show();
            lblMessage.Show();
            clearEvents();
            int id;
            if (int.TryParse(textBoxId.Text, out id))
            {
                if (currentCoord.eventExists(id))
                {
                    // change to event view for deletion confirmation
                    string events = currentCoord.getEventInfoById(id);
                    labelBookings.Text = "Bookings";
                    labelDateTime.Text = "Date/Time";
                    string[] eventFields = events.Split(';');
                    labelNumberInfo.Text = eventFields[0];
                    labelEventInfo.Text = eventFields[1];
                    labelVenueInfo.Text = eventFields[2];
                    labelDateTimeInfo.Text = eventFields[3];
                    labelBookingsInfo.Text = eventFields[4];
                    lblMessage.Text = "Are you sure you want to delete the event with ID " + id + "?";
                    btnConfirm.Show();
                    btnDeny.Show();
                    textBoxId.Hide();
                    labelEventId.Hide();
                    btnSubmit.Hide();
                }
                else
                {
                    lblMessage.Text = "Event with ID " + id + " was not found..";
                }
            }
            else
            {
                lblMessage.Text = "Invalid input for ID search";
            }
        }

        private void btnShowEvents_Click(object sender, EventArgs e)
        {
            // used to bring user back to initial delete customer page
            FormDeleteEvent_Load(sender, e);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBoxId.Text);
            currentCoord.deleteEvent(id);
            btnConfirm.Hide();
            btnDeny.Hide();
            lblMessage.Text = "Event with the ID " + id + " was successfully deleted";
        }

        private void btnDeny_Click(object sender, EventArgs e)
        {
            FormDeleteEvent_Load(sender, e);
        }
    }
}
