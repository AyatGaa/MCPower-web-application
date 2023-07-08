using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstraction
{
    public  interface IRoleService
    {
        public User getUserById(int id);
        public bool IsAdmin(Role role);

    }
}
