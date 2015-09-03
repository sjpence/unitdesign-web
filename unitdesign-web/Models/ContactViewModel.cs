using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace unitdesign_web.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        public string Title { get; set; }

        [Required(ErrorMessage = "Valid email address is required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Company { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }

        [Required(ErrorMessage = "Comments are required")]
        [DataType(DataType.MultilineText)]
        public string Comments { get; set; }

        public DateTime TimeSent { get; set; }
    }
}