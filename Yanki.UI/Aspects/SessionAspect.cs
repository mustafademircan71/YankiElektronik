using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Yanki.Entity.Concrete;

namespace Yanki.UI.Aspects
{
    public class SessionAspect:ActionFilterAttribute,IActionFilter
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
           Admin activeAdmin=context.HttpContext.Session.GetObject<Admin>
        }
    }
}
