using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstractions;
using Domain.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace Repository.Implementation
{
    public class ProductRepo : IProductRepo
    {
        public MCpowerDbcontext _context;
        
        public ProductRepo(MCpowerDbcontext context)
        {
             _context = context;
        }


        //add product
        public void Add(Products p)
        {
            _context.Add(p);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var removed_product = GetProductByID(id);
           
                _context.Remove(removed_product);
                _context.SaveChanges();
            
        }

        //get product by id to be able to remove it
        public Products? GetProductByID(int id)
        {
            return _context.products.Where(x => x.ProductId == id).FirstOrDefault();
        }
        
        public Products Edit(Products p)
        {
            var to_update_product = GetProductByID(p.ProductId);

            _context.products.Update(to_update_product);
            _context.SaveChanges();
            //if (to_update_product != null)
            //{
            //    to_update_product.Date = p.Date;
            //    to_update_product.ProductPrice = p.ProductPrice;
            //    to_update_product.ProductName = p.ProductName;
            //    to_update_product.ProductQuantity = p.ProductQuantity;
            //    to_update_product.Description = p.Description;
                
            //}
            return to_update_product;
        }


     

        public List<Products> GetListOfProducts(int id)
        {
            return _context.products.Where(x => x.ProductId == id).ToList();
        }
    }
}
