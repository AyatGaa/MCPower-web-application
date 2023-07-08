using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        public DateTime Date { get; set; }
        [ForeignKey("Role")]
        public int RoleId { get; set; }

        public User( string email , string password)
        {
            this.Email = email;
            this.Password = password;
          
        }
    }
}
