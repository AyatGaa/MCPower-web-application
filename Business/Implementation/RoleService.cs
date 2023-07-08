using Business.Abstraction;
using Domain.Abstractions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementation
{
    public class RoleService : IRoleService
    {
        private IRoleService _roleService;
        public MCpowerDbcontext _context;

        public RoleService(IRoleService roleService, MCpowerDbcontext _context)
        {
            this._roleService = roleService;
            this._context = _context;
        }

        public User getUserById(int id)
        {
            var u = _context.user.Where(x => x.Id == id).FirstOrDefault();
            return u;
        }

        public bool IsAdmin(Role role)
        {
            var t = _context.role.Where(x => x.Type == role.Type).Any();
            //var isadmin = _context.admins.Where(x=> x.Rol == 1).Any();
            return t;

        }
    }
}

