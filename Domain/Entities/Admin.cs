using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    [Keyless]
    public class Admin
    {
        //User _user;


        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Password { get; set; }
        public DateTime Date { get; set; }

    }
}
