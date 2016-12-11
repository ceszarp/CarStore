using CarStore.Data.Abstract;
using CarStore.Data.Helpers;
using CarStore.WebUI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarStore.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private ICarRepository repository;
        public HomeController(ICarRepository repo)
        {
            repository = repo;
        }

        // GET: Home
        public ActionResult Index()
        {
            repository.SaveBrand(new Data.Models.CarBrand { Name = "BMW" });
            return View();
        }
    }
}