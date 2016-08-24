using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_coding.gr.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [StringLength(30, ErrorMessage = "Please insert a username maximun 30 characters and minimum 2.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string Name { get; set; }


        [Required]
        [StringLengthAttribute(30, ErrorMessage = "Please insert a Surname maximum 30 characters and minimum 2.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Name")]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Birthday")]
        public DateTime Birthday { get; set; }

        [Required]
        [Display(Name="Gender")]
        public string Gender { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Please insert a username maximun 30 characters and minimum 2.", MinimumLength = 2)]
        [DataType(DataType.Text)]
        [Display(Name = "Username")]
        public string Username { get; set; }



        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}
