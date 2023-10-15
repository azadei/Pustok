using Microsoft.AspNetCore.Mvc;
using Pustok.Database;
using System.Collections.Generic;

namespace Pustok
{   
    //controller
    public class HomeController : Controller
    {

        //action
        public ViewResult Index()
        {   
            DbContext dbContext = new DbContext();
            return View(DbContext._products);
        }


        public ViewResult Shop()
        {
            return View();
        }



        //action
        public string Contact()
        {
            return "This is my contact:050234..!";
        }

       
        //action
        public ViewResult About()
        {
            return View();
        }

    }

}

