using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Contact UserContact { get; set; }

    }
    public class Contact
    {
        public int Id { get; set; }
        public string ContactType { get; set; }
        public string ContactNumber { get; set; }
    }


    public class UserDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactDTO UserContactDTO { get; set; }

    }
    public class ContactDTO
    {
        public string ContactType { get; set; }
        public string ContactNumber { get; set; }
    }
}
