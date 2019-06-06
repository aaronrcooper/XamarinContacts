using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace XamarinContacts.Models
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public byte[] ContactImage { get; set; }

        public Contact()
        {

        }
    }
}
