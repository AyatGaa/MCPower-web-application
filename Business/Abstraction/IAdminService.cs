using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstraction
{
   public interface IAdminService
    {
        public bool Login(string email, string password);
        public Admin GetByNameAndPassword(string email, string password);


     
     

    }
}
