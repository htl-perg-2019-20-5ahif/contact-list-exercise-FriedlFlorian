using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HUE01_ContactList
{
    public class IContactList
    {
        int id;
        String firstname;
        String lastname;
        String email;

        public IContactList(int id, string firstname, string lastname, string email)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }

        public int Id { get; set; }
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Email { get; set; }
    }

    
}
