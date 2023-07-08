﻿using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Abstraction
{
    public interface IProductRepo
    {
        //CRUD
        //public Products? GetById(int id);
        public void Add(Products p);
        public void Delete(int id); // get and delete with id
        public Products Edit(Products p);
        public Products? GetProductByID(int id);
       public List<Products> GetListOfProducts(int id);
    }
}
