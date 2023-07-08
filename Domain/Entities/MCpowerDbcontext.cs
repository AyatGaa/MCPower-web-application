using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstractions
{
    public class MCpowerDbcontext : DbContext
    {


        public MCpowerDbcontext( DbContextOptions<MCpowerDbcontext> opt) : base(opt)
        {
      
        }
        public DbSet<Products> products { get; set; }
        public DbSet<Admin> admins { get; set; }
        public DbSet<Role> role { get; set; }
        public DbSet<User> user { get; set; }
    }
}
