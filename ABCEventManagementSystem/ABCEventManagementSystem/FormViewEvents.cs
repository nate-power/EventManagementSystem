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
    public partial class FormViewEvents : Form
    {
        private EventCoordinator currentCoord;

        public FormViewEvents(EventCoordinator eCoord)
        {
            currentCoord = eCoord;
            InitializeComponent();
        }

        private void FormViewEvents_Load(object sender, EventArgs e)
        {
            lblMessage.Show();
            if (currentCoord.eventList()[0] != null && currentCoord.eventList()[0] != "")
            {
                foreach (string events in currentCoord.eventList())
                {
                    // view all events
                    if (events != "" && events != null)
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
    }
}
