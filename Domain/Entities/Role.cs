using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    //one to one relation role <==> user
    public class Role
    {
        [Key]
        public int Id { get; set; }
        
        public string Name { get; set; }
        [Required]
        public int Type { get; set; } // o for admin or 1  for user
    }
}
