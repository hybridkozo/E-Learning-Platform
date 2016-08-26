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
        [StringLength(30, ErrorMessage = "Παρακαλώ εισάγετε όνομα max 30 χαρακτήρες και minimum 2.", MinimumLength = 2)]
        [Display(Name = "Όνομα*")]
        public string Name { get; set; }


        [Required]
        [StringLengthAttribute(30, ErrorMessage = "Παρακαλώ εισάγετε επώνυμο max 30 χαρακτήρες και minimum 2.", MinimumLength = 2)]
        [Display(Name = "Επώνυμο*")]
        public string Surname { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Ημ. Γέννησης*")]
        public DateTime Birthday { get; set; }

        [Required]
        [Display(Name="Φύλο*")]
        public string Gender { get; set; }



        [Required]
        [EmailAddress]
        [Display(Name = "E-mail*")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Ο {0} πρέπει να είναι το λιγότερο {2} έως {1} χαρακτήρες.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Κωδικός*")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Επιβεβαίωση κωδικού*")]
        [Compare("Password", ErrorMessage = "Ο κωδικός επιβεβαίωσης δεν ταιριάζει με τον αρχικό κωδικό.")]
        public string ConfirmPassword { get; set; }
    }
}
