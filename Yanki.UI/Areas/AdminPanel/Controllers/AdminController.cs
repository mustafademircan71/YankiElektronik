using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yanki.Business.Abstract;
using Yanki.Entity.Concrete;
using Yanki.Entity.ViewModels.AdminPanel;

namespace Yanki.UI.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class AdminController : Controller
    {
        private readonly IAdminService _adminService;
        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }
        [HttpGet]
        public IActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public IActionResult LogIn(LoginVm vm)
        {
            Admin admin = _adminService.AdminLogin(vm.Email, vm.Password);
            if (admin!=null&&admin.IsActive!=false)
            {
                return Json(new { result = true });
            }
            return Json(new { Result = false, Message = "Admin Bulunamadı" });
        }
    }
}
