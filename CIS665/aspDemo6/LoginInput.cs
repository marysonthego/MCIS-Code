﻿// Demo 6 - Authentication Basics; LV
// Add this class to create a seperate model for the login credentials provided by the user

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Demo6.Models
{
    public class LoginInput
    {
        [Required(ErrorMessage = "Please enter a username")]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required(ErrorMessage = "Please enter a password")]
        [UIHint("password")]
        [MaxLength(50)]
        public string UserPassword { get; set; }

        public string ReturnURL { get; set; }
    }
}
