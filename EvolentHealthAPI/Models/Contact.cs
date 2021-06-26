using System;
using System.Collections.Generic;

#nullable disable

namespace EvolentHealthAPI.Models
{
    public partial class Contact
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phonenumber { get; set; }
        public bool? Status { get; set; }
    }
}
