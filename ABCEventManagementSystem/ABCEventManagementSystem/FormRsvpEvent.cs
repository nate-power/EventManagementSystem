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
    public partial class FormRsvpEvent : Form
    {
        private EventCoordinator currentCoord;

        public FormRsvpEvent(EventCoordinator eCoord)
        {
            currentCoord = eCoord;
            InitializeComponent();
        }

        private void showContent()
        {   
            // shows content when both events and customers exist 
            labelCustomer.Show();
            labelEvent.Show();
            textBoxCusId.Show();
            textBoxEventId.Show();
            btnCusSubmit.Show();
            labelCusTitle.Show();
            labelEventTitle.Show();
            labelNumber1.Show();
            labelNumber2.Show();
            labelCusName.Show();
            labelEventName.Show();
            labelPhone.Show();
            labelVenue.Show();
            labelNumberInfo1.Show();
            labelNumberInfo2.Show();
            labelCusNameInfo.Show();
            labelEventNameInfo.Show();
            labelPhoneInfo.Show();
            labelVenueInfo.Show();                    
        }

        private void hideContent()
        {
            // hides all content if there are no customers and/or events
            labelCustomer.Hide();
            labelEvent.Hide();
            textBoxCusId.Hide();
            textBoxEventId.Hide();
            btnCusSubmit.Hide();
            labelCusTitle.Hide();
            labelEventTitle.Hide();
            labelNumber1.Hide();
            labelNumber2.Hide();
            labelCusName.Hide();
            labelEventName.Hide();
            labelPhone.Hide();
            labelVenue.Hide();
            labelNumberInfo1.Hide();
            labelNumberInfo2.Hide();
            labelCusNameInfo.Hide();
            labelEventNameInfo.Hide();
            labelPhoneInfo.Hide();
            labelVenueInfo.Hide();
        }

        private void clearFields()
        {            
            labelNumberInfo1.Text = "";
            labelCusNameInfo.Text = "";
            labelPhoneInfo.Text = "";
            labelEventNameInfo.Text = "";
            labelNumberInfo2.Text = "";
            labelVenueInfo.Text = "";
        }

        private void FormRsvpEvent_Load(object sender, EventArgs e)
        {
            lblMessage.ForeColor = System.Drawing.Color.Maroon;
            clearFields();
            textBoxCusId.Text = "";
            textBoxEventId.Text = "";
            hideContent();
            lblMessage.Text = "";
            if (currentCoord.customerList()[0] != null && currentCoord.customerList()[0] != "" && currentCoord.eventList()[0] != null && currentCoord.eventList()[0] != "" && currentCoord.canRegister())
            {
                // display a list of both customers and events to choose from to make RSVP
                foreach (string customer in currentCoord.customerList())
                {
                    if (customer != "")
                    {
                        string[] customerFields = customer.Split(';');
                        labelNumberInfo1.Text += customerFields[0] + "\n\n";
                        labelCusNameInfo.Text += customerFields[1] + "\n\n";
                        labelPhoneInfo.Text += customerFields[2] + "\n\n";
                    }
                }

                foreach (string events in currentCoord.eventList())
                {
                    if (events != "")
                    {
                        string[] eventFields = events.Split(';');
                        labelNumberInfo2.Text += eventFields[0] + "\n\n";
                        labelEventNameInfo.Text += eventFields[1] + "\n\n";
                        labelVenueInfo.Text += eventFields[2] + "\n\n";
                    }
                }
                showContent();
            }
            else
            {
                lblMessage.Text = "Must have at least one customer\n and one event to add an RSVP";
            }
        }

        private void btnCusSubmit_Click(object sender, EventArgs e)
        {
            int cusId, eventId;
            lblCusMessage.Text = "";
            lblEventMessage.Text = "";

            // will only work when both customer and event id are integers
            if (int.TryParse(textBoxCusId.Text, out cusId) && int.TryParse(textBoxEventId.Text, out eventId))
            {
                if (!currentCoord.customerExists(cusId))
                {
                    lblCusMessage.Text = "No customer with the ID " + cusId;
                }
                if (!currentCoord.eventExists(eventId))
                {
                    lblEventMessage.Text = "No event with the ID " + eventId;
                }
                // will only work if both customer and event exist, and if the event is not full or customer has not already registered
                if (currentCoord.customerExists(cusId) && currentCoord.eventExists(eventId) && !currentCoord.eventIsFull(eventId) && !currentCoord.customerRegisteredForEvent(eventId, cusId))
                {                    
                    Event ev = currentCoord.getEvent(eventId);
                    Customer cust = currentCoord.getCustomer(cusId);
                    currentCoord.addRegistration(ev, cust);
                    ev.addAttendee(cust);
                    cust.addBooking();
                    lblMessage.ForeColor = System.Drawing.Color.Black;
                    lblCusMessage.Text = "RSVP Successfully added";
                    textBoxCusId.Text = "";
                    textBoxEventId.Text = "";
                }
                else if (currentCoord.customerExists(cusId) && currentCoord.eventExists(eventId))
                {                    
                    lblCusMessage.Text = "RSVP was not added";
                    textBoxCusId.Text = "";
                    textBoxEventId.Text = "";
                }
            }
            else
            {
                lblCusMessage.Text = "Please enter valid IDs in the fields";
            }
        }
    }
}
