using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using three.Models;
using MvcPhilosopher.Models;

namespace philosophers 
{
    public class InfoController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}