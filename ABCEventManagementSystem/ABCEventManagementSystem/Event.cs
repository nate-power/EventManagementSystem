using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCEventManagementSystem
{
    public class Event
    {
        private int eventId;
        private string eventName;
        private string venue;
        private Date eventDate;
        private int maxAttendees;
        private int numAttendees;
        private string dateCreated;
        private Customer[] attendeeList;

        public Event(int eventId, string name, string venue, Date eventDate, int maxAttendees)
        {
            this.eventId = eventId;
            this.eventName = name;
            this.venue = venue;
            this.eventDate = eventDate;
            this.maxAttendees = maxAttendees;
            numAttendees = 0;
            attendeeList = new Customer[maxAttendees];
            dateCreated = DateTime.Now.ToString(@"MM\/dd\/yyyy hh:mm tt");
        }

        public int getEventId() { return eventId; }
        public string getEventName() { return eventName; }
        public string getVenue() { return venue; }
        public int getMaxAttendees() { return maxAttendees; }
        public int getNumAttendees() { return numAttendees; }
        public Date getDate() { return eventDate; }

        public bool addAttendee(Customer c)
        {
            // add customer to attendee list
            if (numAttendees >= maxAttendees) { return false; }
            attendeeList[numAttendees] = c;
            numAttendees++;
            return true;
        }

        private int findAttendee(int custId)
        {
            for (int x = 0; x < maxAttendees; x++)
            {
                if (attendeeList[x] != null && attendeeList[x].getId() == custId)
                    return x;
            }
            return -1;
        }

        public bool removeAttendee(int custId)
        {
            // used when customer is deleted
            int loc = findAttendee(custId);
            if (loc == -1) return false;
            attendeeList[loc] = attendeeList[numAttendees - 1];
            numAttendees--;
            return true;
        }

        public string[] getAttendees()
        {
            // used in displaying the list of attendees in event view
            string s = "";
            for (int x = 0; x < numAttendees; x++)
            {
                s += attendeeList[x].getId() + ";" + attendeeList[x].getFirstName() + " " + attendeeList[x].getLastName() + "~";
            }

            string[] attendees = s.Split('~');

            return attendees;
        }

        public bool hasAttendee(int cid)
        {
            //check if a specific customer is registered for this event
            if (numAttendees > 0)
            {
                return findAttendee(cid) != -1;
            }
            return false;
        }

        public Customer[] getAttendeeArray()
        {
            return attendeeList;
        }


        public string toString()
        {
            string s = eventId + ";" + eventName + ";" + venue + ";" + eventDate + ";" + numAttendees + ";" + (maxAttendees - numAttendees);
            return s;
        }
        public string deleteEventString()
        {
            string s = eventId + ";" + eventName + ";" + venue + ";" + eventDate + ";" + numAttendees;
            return s;
        }

        public bool isFull()
        {
            //check if this event has reached maximum attendance
            return numAttendees >= maxAttendees;
        }
    }
}
