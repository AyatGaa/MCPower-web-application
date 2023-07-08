using Business.Abstraction;
using Business.Implementation;
using Domain.Abstractions;
using Domain.Entities;
using MessagePack.Formatters;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Newtonsoft.Json;
using NuGet.Protocol.Plugins;
using System.Data;
using System.Net;

namespace MCPowerDemo.Controllers
{
    public class AdminController : Controller
    {

        //DI
        private IAdminService adminService;
        private IProductService productService;
        public MCpowerDbcontext _context;
        public AdminController(IAdminService adminService , IProductService productService,
                                MCpowerDbcontext _context)
        {
            this.adminService = adminService;
            this.productService = productService;
            this._context = _context;
        }


        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
  
        [HttpPost]
        public ActionResult Login(Admin a)
        {
          
            var user = adminService.GetByNameAndPassword(a.Email, a.Password);
            if (user != null)
            {
                HttpContext.Session.SetString("demo", JsonConvert.SerializeObject(user));
                return RedirectToAction("AdminHome");
            }
            return View();
        }
    
        [HttpGet]
        public ActionResult AdminHome(Role r , int id)
        {
            if(r.Type ==1)
            {
                r.Id = id;
            }
          
            //return View();
            return RedirectToAction("Show");
        }

        // GET: AdminController
        [HttpGet]
        public ActionResult Show()
        {
            List<Products> products = _context.products.ToList();
            return View(products);
        }

        // GET: AdminController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Products p)
        {
            try
            {
                productService.Add(p);
            }
            catch
            {
                return RedirectToAction("AdminHome");
            }
            return RedirectToAction("AdminHome");
        }

        // GET: AdminController/Edit/5
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var e = productService.GetProductByID(id);
            return View(e);
            
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Products p)
        {
            _context.Attach(p); //Track item which need to edited
            _context.Entry(p).State =EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Show");
        }

        // GET: AdminController/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Products p = productService.GetProductByID(id);
            return View(p);
        }
        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Products p)
        {

            try
            {
                var prod = productService.GetProductByID(p.ProductId);
                if (prod != null)
                {
                    productService.Delete(prod.ProductId);              
                    return RedirectToAction("Show");
                }
            }
            catch
            {
                return RedirectToAction("Show");
            }
            return RedirectToAction("Show");
        }

        public ActionResult Details(int id)
        {

           // Products products = _context.products.ToList();
          
            Products p =  productService.GetProductByID(id);
            return View(p);
        }

       
    }
}

 