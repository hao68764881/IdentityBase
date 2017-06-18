﻿using System;
using System.ComponentModel.DataAnnotations;

namespace IdentityBase.Public.Actions.Recover
{
    public class RecoverConfirmInputModel
    {
        [Required]
        [StringLength(100)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [StringLength(100)]
        public string PasswordConfirm { get; set; }
        
        [Required]
        public string Key { get; set; }
    }
}