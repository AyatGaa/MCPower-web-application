using Business.Abstraction;
using Domain.Abstraction;
using Domain.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace Business.Implementation
{
    public class ProductService : IProductService
    {
        private IProductRepo _repo;
        public ProductService(IProductRepo _rep)
        {
            this._repo = _rep;
        }

        public void Add(Products p)
        {
            _repo.Add(p);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public Products? GetProductByID(int id)
        {
            return _repo.GetProductByID(id);
        }

      

        public Products Edit(Products p)
        {
           return _repo.Edit(p);
        }

      public   List<Products>  GetListOfProducts(int id)
        {
            return _repo.GetListOfProducts( id);    
        }

     
    }
}
