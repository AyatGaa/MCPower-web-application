using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstraction
{
    public  interface IUserRepo 
    {
       // public Role Role { get; set; }
        public bool IsAdmin (Role role );
        public User GetUserById(int id);
            

    }
}
