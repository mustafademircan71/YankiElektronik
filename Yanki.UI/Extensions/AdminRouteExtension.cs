using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yanki.UI.Extensions
{
    public static class AdminRouteExtension
    {
        public static void AdminRoute(this IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "adminLogin",
                    areaName: "AdminPanel",
                    pattern: "admin",
                    defaults: new { controller = "Admin", action = "LogIn" });
            });
        }
    }
}
