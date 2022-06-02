using EFDBFirstApproach2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFDBFirstApproach2.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        March2022Entities db;
        public ProductsController()
        {
            db = new March2022Entities();   
        }
        
        public ActionResult Index()
        {
            var allproducts = db.tblProducts.ToList();
            //var allproducts = db.tblProducts.Where(p => p.catId > 1 && p.price >5000);
            return View(allproducts);
        }

        public ActionResult Details(int ?id )
        {
            var product= db.tblProducts.Where(p => p.productId == id).FirstOrDefault(); 

            return View(product);
        }


    }
}