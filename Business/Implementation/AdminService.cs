using Business.Abstraction;
using Domain.Abstractions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Repository.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementation
{
    public  class AdminService : IAdminService
    {
        private AdminRepo _admdinrepo;
        private ProductRepo Productrepo;
        MCpowerDbcontext _context;
        public AdminService(MCpowerDbcontext context)
        {
           this._context = context;
        }

        public AdminService(AdminRepo admdinrepo , ProductRepo productrepo) 
        {
            this._admdinrepo= admdinrepo;
            this.Productrepo= productrepo;
        }   

        public bool Login(string email, string password)
        {
            return _context.admins.Where(a => a.Email == email && a.Password == password).Any();
        }

      public  Admin GetByNameAndPassword(string email, string password)
        {
          
            return _context.admins.Where(x => x.Email == email && x.Password == password).FirstOrDefault();

        }

        //public Products GetProductByID(int id)
        //{
        //    return _context.products.Where(s => s.ProductId == id).FirstOrDefault();
        //}
        //public Products Edit(Products p)
        //{
 
        //    var to_update_product = GetProductByID(p.ProductId);
        //    if (to_update_product != null)
        //    {
        //        to_update_product.Date = p.Date;
        //    }
        //    return to_update_product;
        //    //_context.products.Update(p);
        //    //_context.SaveChanges();
        //}
    }
}
