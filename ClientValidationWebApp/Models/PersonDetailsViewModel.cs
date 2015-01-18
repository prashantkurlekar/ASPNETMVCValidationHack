using System;
using System.ComponentModel.DataAnnotations;

namespace ClientValidationWebApp.Models
{
    public class PersonDetailsViewModel
    {
        //Basic details
        [Required(ErrorMessage = "Please enter First name")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Display Name")]
        [MinLength(8, ErrorMessage = "Display name should be minimum of 8 characters")]
        public string DisplayName { get; set; }

        [Required(ErrorMessage = "Please enter Email address")]
        [RegularExpression(@"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$", ErrorMessage = "Please enter valid email address")]
        [Display(Name = "Email")]
        public string Email { get; set; }


        //Contact details
        [Required(ErrorMessage = "Please enter address line 1")]
        [Display(Name = "Address line 1")]
        public string AddressLine1 { get; set; }

        [Display(Name = "Address line 2")]
        public string AddressLine2 { get; set; }

        [Required(ErrorMessage = "Please enter mobile number")]
        [RegularExpression(@"^([0-9]( |-)?)?(\(?[0-9]{3}\)?|[0-9]{3})( |-)?([0-9]{3}( |-)?[0-9]{4}|[a-zA-Z0-9]{7})$", ErrorMessage = "Please enter valid mobile number")]
        [Display(Name = "Mobile")]
        public string Mobile { get; set; }

        [Display(Name = "Phone")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter Post Code")]
        [Display(Name = "Post code")]
        public string PostCode { get; set; }

        //Other Details
        [Required(ErrorMessage = "Please enter Date of birth")]
        [Display(Name = "Date of birth")]
        public DateTime DOB { get; set; }

        [Display(Name = "Other details")]
        public string Other { get; set; }
    }
}
