﻿using System.ComponentModel.DataAnnotations;

namespace StudentServiceApplication.ViewModels
{
    public class UserLogin
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
