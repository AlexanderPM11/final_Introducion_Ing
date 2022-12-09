using Example.Core.Application.Interfaces.Services;
using Library.Core.Applicantion.ViewModels.Gender;
using Library_Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Library_Final.Controllers
{
    public class HomeController : Controller
    {
        private readonly IGenderServices _service;

        public HomeController(IGenderServices genderServices)
        {
            _service = genderServices;
        }

        public IActionResult Index()
        {
            return View();
        }  
        
        [HttpPost]
        public async Task< IActionResult> Create(SaveGenderViewModel model)
        {
           await _service.Add(model);

            return View("Index");
        }

    }
}
