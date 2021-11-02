using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yanki.Business.Abstract;

namespace Yanki.UI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AdminController : Controller
    {
        //private readonly IAdminService _adminService;
        //public AdminController(IAdminService adminService)
        //{
        //    _adminService = adminService;
        //}
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult LogIn(LoginVm vm)
        //{

        //}
    }
}
