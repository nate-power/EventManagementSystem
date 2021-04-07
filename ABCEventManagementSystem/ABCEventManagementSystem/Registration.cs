using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCEventManagementSystem
{
    public class Registration
    {
        private int registrationId;
        private string date;
        private Event event_;
        private Customer customer;

        public Registration(int registrationId, Event event_, Customer customer)
        {
            this.registrationId = registrationId;
            this.date = DateTime.Now.ToString(@"MM\/dd\/yyyy h\:mm tt");
            this.event_ = event_;
            this.customer = customer;
        }

        public int getId() { return registrationId; }
        public string getDate() { return date; }
        public Event getEvent() { return event_; }
        public Customer getCustomer() { return customer; }

        public string toString()
        {
            // used in RSVP views
            string name = customer.getFirstName() + " " + customer.getLastName();
            int eventId = event_.getEventId();
            string s = registrationId + ";" + date + ";" + name + ";" + eventId + "~";
            return s;
        }
    }
}
