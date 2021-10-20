﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminFrontEnd.Models
{
    public class UserAccounts
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserUserName { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string UserRole { get; set; }
    }
}
