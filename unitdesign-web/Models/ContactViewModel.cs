using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace unitdesign_web.Models
{
    public class ContactViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Comments { get; set; }
        public DateTime TimeSent { get; set; }
    }
}