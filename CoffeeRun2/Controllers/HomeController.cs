using System;
using System.Web.Mvc;
using Enzo.CoffeeRun2.Web.Models;
using Enzo.CoffeeRun2.Web.Repositories;

namespace Enzo.CoffeeRun2.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly CoffeeRequestRepository _requestRepository;
        
        public HomeController(CoffeeRequestRepository requestRepository)
        {
            _requestRepository = requestRepository;
        }

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(CoffeeRequest forCoffee)
        {
            _requestRepository.Add(forCoffee);
            return View();
        }

    }
}
