using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ABCEventManagementSystem
{
    public class CustomerManager
    {
        private static int currentCustNumber;
        private int maxNumCustomers;
        private int numCustomers;
        private Customer[] customerList;

        public CustomerManager(int ccn, int max)
        {
            currentCustNumber = ccn;
            maxNumCustomers = max;
            numCustomers = 0;
            customerList = new Customer[maxNumCustomers];
        }

        public int getNumCustomers() { return numCustomers; }

        public bool isValidNumber(string ph)
        {
            // check if phone number entered by user follows particular formatting
            if (!Regex.IsMatch(ph, "^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\\s\\./0-9]*$"))
            {
                return false;
            }
            return true;
        }

        public bool addCustomer(string fn, string ln, string ph)
        {
            // create an object of type Customer only if data entered does not contain delimiters, has a valid phone number and max number of customers have not been entered
            if (numCustomers >= maxNumCustomers || !isValidNumber(ph) || fn.Contains(";") || ln.Contains(";") || fn.Contains("~") || ln.Contains("~"))
            {
                return false;
            }
            Customer c = new Customer(currentCustNumber, fn, ln, ph);
            currentCustNumber++;
            customerList[numCustomers] = c;
            numCustomers++;
            return true;
        }

        public int findCustomer(int cid)
        {
            // returns ID of customer to be used for various functions throughout the program when checking customer existence, customer deletion and customer retrieval
            for (int x = 0; x < numCustomers; x++)
            {
                if (customerList[x].getId() == cid)
                    return x;
            }
            return -1;
        }

        public bool customerExist(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) { return false; }
            return true;
        }

        public Customer getCustomer(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) { return null; }
            return customerList[loc];
        }

        public string getCustomerInfo(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) 
            {
                return "There is no customer with id " + cid + ".";
            }
            return customerList[loc].toString();
        }

        public bool deleteCustomer(int cid)
        {
            int loc = findCustomer(cid);
            if (loc == -1) { return false; }
            customerList[loc] = customerList[numCustomers - 1];
            numCustomers--;
            return true;
        }

        public string[] getCustomerList()
        {
            // when customer is deleted, the list will be reorganized based on customer ID
            string s = "";
            int currentId;
            int[] customerIDs = new int[numCustomers];
            for (int x = 0; x < numCustomers; x++)
            {
                customerIDs[x] = customerList[x].getId();
            }
            Array.Sort(customerIDs);

            // populate regorganized list with customer information made to be presented on customer views
            for (int x = 0; x < numCustomers; x++)
            {
                currentId = customerIDs[x];
                for (int y = 0; y < numCustomers; y++)
                {
                    if (currentId == customerList[y].getId())
                    {
                        s += customerList[y].getId() + ";" + customerList[y].getFirstName() + " " + customerList[y].getLastName() + ";" + customerList[y].getPhone() + "~";
                        break;
                    }
                }                
            }
            string[] customer = s.Split('~');
            return customer;
        }

        public void deleteBookings(Customer[] bookedCustomers)
        {
            foreach (Customer c in bookedCustomers)
            {
                if (c != null)
                {
                    c.removeBooking();
                }
            }
        }
    }
}
