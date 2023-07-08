using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstraction
{
    public interface IAdminRepo
    {
       public Admin GetByNameAndPassword(string email ,string password);


    }
}
