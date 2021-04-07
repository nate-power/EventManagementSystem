using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCEventManagementSystem
{
    public partial class FormAddEvent : Form
    {
        private EventCoordinator currentCoord;
        public FormAddEvent(EventCoordinator eCoord)
        {
            currentCoord = eCoord;
            InitializeComponent();
        }

        private void FormAddEvent_Load(object sender, EventArgs e)
        {
            textBoxEvent.Focus();
            //set the datePicker inital value the minimum date allowed to be set to current date
            datePicker.Value = DateTime.Now;
            datePicker.MinDate = DateTime.Now;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            textBoxEvent.Focus();
            string eventName, venue;
            int day, month, year, hour, minute, maxAttendees;
            Date eventDate;

            lblMessage.ForeColor = System.Drawing.Color.Maroon;
            if (textBoxEvent.Text == "" || textBoxVenue.Text == "" || textBoxMaxAttendees.Text == "")
            {
                lblMessage.Text = "Please Fill In Information";
            }
            else
            {
                eventName = textBoxEvent.Text.Trim();
                venue = textBoxVenue.Text.Trim();
                day = datePicker.Value.Day;
                month = datePicker.Value.Month;
                year = datePicker.Value.Year;
                hour = timePicker.Value.Hour;
                minute = timePicker.Value.Minute;
                eventDate = new Date(day, month, year, hour, minute);
                
                if (int.TryParse(textBoxMaxAttendees.Text, out maxAttendees))
                {
                    if (currentCoord.venueIsAvailable(venue, eventDate) && currentCoord.addEvent(eventName, venue, eventDate, maxAttendees))
                    {                        
                        lblMessage.ForeColor = System.Drawing.Color.Black;
                        lblMessage.Text = "Event Successfully added";
                        textBoxEvent.Text = "";
                        textBoxVenue.Text = "";
                        textBoxMaxAttendees.Text = "";
                        datePicker.Value = DateTime.Now;
                    }
                    else if (!currentCoord.venueIsAvailable(venue, eventDate))
                    {
                        lblMessage.Text = "This venue is already scheduled for this date: " + eventDate;
                    }
                    else
                    {                        
                        lblMessage.Text = "Event Not Added";
                    }
                }
                else
                {
                    lblMessage.Text = "Max Attendees must be an integer";
                }
            }          
        }      
    }
}
