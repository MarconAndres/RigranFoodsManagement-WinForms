using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CustomerContact
    {
        public int ID { get; set; }
        public int IdCustomer { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RolePosition {  get; set; }
        public string Email {  get; set; }
        public string PhoneNumber { get; set; }

    }
}
