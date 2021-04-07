using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCEventManagementSystem
{
    public class EventManager
    {
        private static int currentEventId;
        private int maxEvents;
        private int numEvents;
        private Event[] eventList;

        public EventManager(int idSeed, int max)
        {
            currentEventId = idSeed;
            maxEvents = max;
            numEvents = 0;
            eventList = new Event[maxEvents];
        }

        public int getNumEvents() { return numEvents; }

        public bool addEvent(string name, string venue, Date eventDate, int maxAttendees)
        {
            // only adds event if event fields do not contain a delimiter, max attendees for the event was not set to 0 and the number of events hasn't reached it's maximum
            if (numEvents >= maxEvents || name.Contains(";") || venue.Contains(";") || name.Contains("~") || venue.Contains("~") || maxAttendees == 0) 
            { 
                return false; 
            }
            Event e = new Event(currentEventId, name, venue, eventDate, maxAttendees);
            eventList[numEvents] = e;
            numEvents++;
            currentEventId++;
            return true;
        }

        private int findEvent(int eid)
        {
            // used in various methods such as checking if event exists, deletion of event and event data retrieval
            for (int x = 0; x < numEvents; x++)
            {
                if (eventList[x].getEventId() == eid)
                    return x;
            }
            return -1;
        }

        public bool eventExists(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            return true;
        }

        public Event getEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return null; }
            return eventList[loc];
        }

        public bool deleteEvent(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) { return false; }
            eventList[loc] = eventList[numEvents - 1];
            numEvents--;
            return true;
        }
        public string getEventInfo(int eid)
        {
            int loc = findEvent(eid);
            if (loc == -1) 
            {
                return "There is no event with id " + eid + "."; 
            }
            return eventList[loc].toString();
        }
        public string[] getEventList()
        {
            // used in the display of events in event view panels
            string s = "";
            int currentId;
            int[] eventIDs = new int[numEvents];

            for (int x = 0; x < numEvents; x++)
            {
                eventIDs[x] = eventList[x].getEventId();
            }

            Array.Sort(eventIDs);

            // populate event list with sorted events
            for (int x = 0; x < numEvents; x++)
            {
                currentId = eventIDs[x];
                for (int y = 0; y < numEvents; y++)
                {
                    if (currentId == eventList[y].getEventId())
                    {
                        s += eventList[y].getEventId() + ";" + eventList[y].getEventName() + ";" + eventList[y].getVenue() + "~";
                        break;
                    }
                }
            }
            string[] events = s.Split('~');
            return events;           
        }

        public bool eventIsFull(int eid)
        {
            //return true if event has reached max attendance
            if (eventExists(eid))
            {
                Event e = getEvent(eid);
                return e.isFull();
            }
            return true;
        }

        public bool venueIsAvailable(string venue, Date date)
        {
            //return true if venue is not booked on given date
            foreach (Event e in eventList)
            {
                if (e != null && e.getVenue() == venue && e.getDate().Equals(date))
                {
                    return false;
                }
            }
            return true;
        }

        public void removeCustomerFromEvents(int cid)
        {
            //remove customer with ID cid from all events for which they were registered
            foreach (Event e in eventList)
            {
                if (e != null)
                {
                    e.removeAttendee(cid);
                }
            }
        }

        public bool customerRegisteredForEvent(int eid, int cid)
        {
            //return true if customer with ID cid is already registered for event with ID eid
            
            Event e = getEvent(eid);
            return e.hasAttendee(cid);
        }

        public string[] getAttendeeList(int eid)
        {
            Event e = getEvent(eid);
            return e.getAttendees();
        }
    }
}
