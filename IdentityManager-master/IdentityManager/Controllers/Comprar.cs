﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityManager.Controllers
{
    public class Comprar : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
