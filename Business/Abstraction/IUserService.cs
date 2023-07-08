using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstraction
{
    public  interface IUserService
    {
        //
       public bool IsAdmin(string email , string password);
        public bool Regestration (string email, string password);
        public void getAdminbyRoll(Role r);
      
        public User GetUserById(int id);
        

    }
}
