
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstraction;
using Domain.Abstractions;

namespace Repository.Implementation
{
    public class AdminRepo : IAdminRepo
    {
       

        public MCpowerDbcontext _context;
        public AdminRepo(MCpowerDbcontext context) 
        {
            _context = context;
        }
    
        public Admin? GetByNameAndPassword(string email , string password)
        {
            return _context.admins.Where(x => x.Password == password && x.Email == email).FirstOrDefault();
           
        }
    }
}
