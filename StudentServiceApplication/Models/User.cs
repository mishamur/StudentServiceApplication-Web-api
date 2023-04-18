﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Composition.Convention;

namespace StudentServiceApplication.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid UserId { get; set; }
        [Required]
        public string? Password { get; set; }
        [Required]
        public string? Email { get; set; }
       
        public UserProfile? UserProfile { get; set; }
        public ICollection<Skill> Skills { get; } = new List<Skill>();
        public ICollection<Language> Languages { get; } = new List<Language>();
        public ICollection<Interes> Interests { get; } = new List<Interes>();
    }
}
