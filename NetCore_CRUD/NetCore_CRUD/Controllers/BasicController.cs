using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NetCore_CRUD.Controllers
{
    public class BasicController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}