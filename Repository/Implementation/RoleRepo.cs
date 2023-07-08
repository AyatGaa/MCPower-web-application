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
    public class RoleRepo : IRoleRepo
    {
        public MCpowerDbcontext _context;
        public RoleRepo(MCpowerDbcontext context)
        {
            _context = context;
        }

        public User getUserById(int id)
        {
          var u = _context.user.Where(x=> x.Id == id ).FirstOrDefault();
            return u;
        }

        public bool IsAdmin(Role role)
        {
            var t = _context.role.Where(x=>x.Type == role.Type).Any();
            //var isadmin = _context.admins.Where(x=> x.Rol == 1).Any();
            return t;

        }
    }
}
