using System;
using System.ComponentModel.DataAnnotations;

namespace ClientValidationWebApp.Models
{
    public class EmployeeViewModel
    {
        //Basic details
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string Mobile { get; set; }

        //Address
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Phone { get; set; }
        [Required]
        public string PostCode { get; set; }

        //Other Details
        [Required]
        public DateTime DOB { get; set; }
        public string Other { get; set; }
    }
}
