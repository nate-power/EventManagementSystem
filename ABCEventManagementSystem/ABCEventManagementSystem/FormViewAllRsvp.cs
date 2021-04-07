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
    public partial class FormViewAllRsvp : Form
    {
        private EventCoordinator currentCoord;

        public FormViewAllRsvp(EventCoordinator eCoord)
        {
            currentCoord = eCoord;
            InitializeComponent();
        }

        private void FormViewAllRsvp_Load(object sender, EventArgs e)
        {
            lblMessage.Show();
            if (currentCoord.registrationList()[0] != null && currentCoord.registrationList()[0] != "")
            {
                // show a list of all reservations
                foreach (string registration in currentCoord.registrationList())
                {
                    if (registration != "")
                    {
                        lblMessage.Hide();
                        string[] registrationFields = registration.Split(';');
                        labelNumberInfo.Text += registrationFields[0] + "\n\n";
                        labelDateInfo.Text += registrationFields[1] + "\n\n";
                        labelNameInfo.Text += registrationFields[2] + "\n\n";
                        labelEventId.Text += registrationFields[3] + "\n\n";
                    }
                }
            }
        }
    }
}
