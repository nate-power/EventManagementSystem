using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCEventManagementSystem
{
    public class RegistrationManager
    {
        int currentRegNum;
        int maxRegistrations;
        int numRegistrations;
        Registration[] registrationList;

        public RegistrationManager(int currentRegNum, int maxRegistrations)
        {
            this.currentRegNum = currentRegNum;
            this.maxRegistrations = maxRegistrations;
            this.numRegistrations = 0;
            this.registrationList = new Registration[maxRegistrations];
        }

        public bool addRegistration(Event ev, Customer cust)
        {
            if (numRegistrations < maxRegistrations)
            {
                registrationList[numRegistrations] = new Registration(currentRegNum, ev, cust);
                numRegistrations++;
                currentRegNum++;
                return true;
            }
            return false;
        }

        public void deleteCustomerRegistration(int cid)
        {
            // registration for event is removed when customer is deleted
            int n = numRegistrations;
            for (int x = 0; x < n; x++)
            {
                if (registrationList[x] != null && registrationList[x].getCustomer().getId() == cid)
                {
                    registrationList[x] = registrationList[numRegistrations - 1];
                    numRegistrations--;
                }
            }
        }

        public void deleteEventRegistration(int eid)
        {
            int n = numRegistrations;
            for (int x = 0; x < n; x++)
            {
                if (registrationList[x] != null && registrationList[x].getEvent().getEventId() == eid)
                {
                    registrationList[x] = registrationList[numRegistrations - 1];
                    numRegistrations--;
                }
            }
        }


        public string[] getRegistrationList()
        {  
            // will resort the list of registered customers when a registration is deleted
            string s = "";
            int currentId;
            int[] registrationIDs = new int[numRegistrations];

            for (int x = 0; x < numRegistrations; x++)
            {
                registrationIDs[x] = registrationList[x].getId();
            }
            Array.Sort(registrationIDs);

            // populate regorganized list with registration information made to be presented on RSVP views
            for (int x = 0; x < numRegistrations; x++)
            {
                currentId = registrationIDs[x];
                for (int y = 0; y < numRegistrations; y++)
                {
                    if (currentId == registrationList[y].getId())
                    {
                        s += registrationList[y].getId() + ";" + registrationList[y].getDate() + ";" + registrationList[y].getCustomer().getFirstName() + " " + registrationList[y].getCustomer().getLastName() + ";" + registrationList[y].getEvent().getEventId() + "~";
                        break;
                    }
                }                
            }
            string[] registration = s.Split('~');
            return registration;
        }
    }
}
