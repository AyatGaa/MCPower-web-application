using Business.Abstraction;
using Domain.Abstractions;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementation
{
    /// <summary>
    /// need to DI b constructor
    /// 
    /// </summary>
    
    public class UserService : IUserService
    {
        //DI ==> active it in program
        private IUserService _userService;
        public MCpowerDbcontext _context;

        public UserService(IUserService userService, MCpowerDbcontext _context)
        {
            this._userService = userService;
            this._context = _context;
        }

        // after finish logic create controller with 
        //repo transient // service scoped ==> best practice
        public bool IsAdmin(string email, string password)
        {
            return _userService.IsAdmin(email, password);
        }

        public bool Regestration(string email, string password)
        {
            return _userService.Regestration(email, password);
        }
        public void getAdminbyRoll(Role r)
        {
            var adminbid = _context.role.Where(x => x.Type == 1).FirstOrDefault();
            
        }
   
        public User GetUserById(int id)
        {
            return _context.user.Where(x => x.Id == id)
                                .FirstOrDefault();
        }


    }
}
