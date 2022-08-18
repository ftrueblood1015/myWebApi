using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace myWebApi.Models
{
    public class Employee
    {
        [Required]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int SocialSecurityNumber { get; set; }
        public int Age { get; set; }
        public DateTime HireDate { get; set; }
        public bool Terminated { get; set; }
    }
}
