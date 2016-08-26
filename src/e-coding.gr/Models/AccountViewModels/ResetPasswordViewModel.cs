using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_coding.gr.Models.AccountViewModels
{
    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Ο {0} πρέπει να είναι από {2} έως {1} χαρακτήρες.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Επιβεβαίωση κωδικού")]
        [Compare("Password", ErrorMessage = "Ο κωδικός επιβεβαίωσης δεν ταιριάζει.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }
}
