﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace e_coding.gr.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Display(Name="Κωδικός")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Να με θυμάσαι?")]
        public bool RememberMe { get; set; }
        public ApplicationUser Username { get; internal set; }
    }
}
