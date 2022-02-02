using _13130_egzamin_z_asp_net.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace _13130_egzamin_z_asp_net.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            return View();
        }
    }
}
