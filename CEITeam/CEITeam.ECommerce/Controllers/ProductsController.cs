using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CEITeam.ECommerce.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CEITeam.ECommerce.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult AddEdit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }
    }
}