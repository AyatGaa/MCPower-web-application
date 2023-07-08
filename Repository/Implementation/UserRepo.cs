using Domain.Abstraction;
using Domain.Abstractions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class UserRepo : IUserRepo
    {
        public MCpowerDbcontext _context;
        public UserRepo(MCpowerDbcontext context)
        {
            _context = context;
        }
        public bool IsAdmin(Role role)
        {
      
            if (role.Type == 1)
                return true;
            
             return false;
        }
        public User GetUserById(int id)
        {
            return _context.user.Where(x => x.Id == id)
                                .FirstOrDefault();
        }

        
    }
}
