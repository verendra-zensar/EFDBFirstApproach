using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFDBFirstApproach2.Models;

namespace EFDBFirstApproach2.Controllers
{
    public class CategorisController : Controller
    {
        // GET: Categoris
        public ActionResult Index()
        {
            March2022Entities db = new March2022Entities();
            var categoris = db.tblCategories.ToList();  
            return View(categoris);
        }





    }
}