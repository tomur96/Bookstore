using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Nick { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNumber { get; set; }
        public string PostalCode { get; set; }
    }
}
