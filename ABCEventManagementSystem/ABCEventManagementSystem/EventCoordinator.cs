using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCEventManagementSystem
{
    public class EventCoordinator
    {
        CustomerManager custMan;
        EventManager eventMan;
        RegistrationManager regMan;

        public EventCoordinator(int custIdSeed, int maxCust, int eventIdSeed, int maxEvents, int regIdSeed, int maxRegistrations)
        {
            custMan = new CustomerManager(custIdSeed, maxCust);
            eventMan = new EventManager(eventIdSeed, maxEvents);
            regMan = new RegistrationManager(regIdSeed, maxRegistrations);
        }

        //customer related methods
        public bool addCustomer(string fname, string lname, string phone)
        {
            return custMan.addCustomer(fname, lname, phone);
        }

        public string[] customerList()
        {
            return custMan.getCustomerList();
        }

        public string getCustomerInfoById(int id)
        {
            return custMan.getCustomerInfo(id);
        }
        public bool deleteCustomer(int id)
        {
            regMan.deleteCustomerRegistration(id);
            eventMan.removeCustomerFromEvents(id);
            return custMan.deleteCustomer(id);
        }

        public bool customerExists(int id)
        {
            return custMan.customerExist(id);
        }

        public Customer getCustomer(int id)
        {
            return custMan.getCustomer(id);
        }

        // Event related methods
        public bool addEvent(string name, string venue, Date eventDate,  int maxAttendee)
        {
            return eventMan.addEvent(name, venue, eventDate, maxAttendee);
        }

        public string[] eventList()
        {
            return eventMan.getEventList();
        }

        public string getEventInfoById(int id)
        {
            return eventMan.getEventInfo(id);
        }

        public bool eventExists(int id)
        {
            return eventMan.eventExists(id);
        }

        public Event getEvent(int id)
        {
            return eventMan.getEvent(id);
        }

        public bool deleteEvent(int id)
        {
            //check if inputted event exists
            if (!eventMan.eventExists(id))
            {
                return false;
            }
            //decrement number of bookings for all customers who are booked for deleted event
            Customer[] bookedCustomers = eventMan.getEvent(id).getAttendeeArray();
            custMan.deleteBookings(bookedCustomers);
            //delete all registrations related to deleted event
            regMan.deleteEventRegistration(id);
            //delete event
            return eventMan.deleteEvent(id);
        }


        public bool eventIsFull(int id)
        {
            return eventMan.eventIsFull(id);
        }

        public bool venueIsAvailable(string venue, Date eventDate)
        {
            //check if venue is available on a given date. a venue can only have one event per day
            return eventMan.venueIsAvailable(venue, eventDate);
        }

        // Registration related methods
        public bool addRegistration(Event ev, Customer cust)
        {
            return regMan.addRegistration(ev, cust);
        }

        public string[] registrationList()
        {
            return regMan.getRegistrationList();
        }

        public bool canRegister()
        {
            //returns true if there is at least one customer and one event in the system
            return eventMan.getNumEvents() > 0 && custMan.getNumCustomers() > 0;
        }

        public bool customerRegisteredForEvent(int eid, int cid)
        {
            //return true if a customer with ID cid is already registered for event with ID eid
            return eventMan.customerRegisteredForEvent(eid, cid);
        }

        public string[] attendeeList(int id)
        {
            return eventMan.getAttendeeList(id);
        }
    }
}
