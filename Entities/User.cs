﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace web_api_labclass_4_mar_25.Entities
{
    [Index(nameof(Email), IsUnique=true)]
    [Index(nameof(Username), IsUnique= true)]
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Username { get; set; }
    }
}
