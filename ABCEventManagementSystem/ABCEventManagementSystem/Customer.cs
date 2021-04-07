﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCEventManagementSystem
{
    public class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phone;
        private int bookings;

        public Customer(int cId, string fname, string lname, string ph)
        {
            bookings = 0;
            customerId = cId;
            firstName = fname;
            lastName = lname;
            phone = ph;
        }

        public int getId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getPhone() { return phone; }
        public int getNumBookings() { return bookings; }
        public string toString()
        {
            // used to display customer information in view panels
            string s = customerId + ";" + firstName + " " + lastName + ";" + phone + ";" + bookings;
            return s;
        }
        public void addBooking()
        {
            bookings++;
        }

        public void removeBooking()
        {
            bookings--;
        }

    }
}
