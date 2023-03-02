using Amazoon.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazoon.Controllers
{
    public class HomeController : Controller
    {
        private IBookStoreRepository repo;

        public HomeController (IBookStoreRepository temp)
        {
            repo = temp;
        }
        public IActionResult Index()
        {
            var x = repo.Books.ToList();

            return View(x);
        }
    }
}
