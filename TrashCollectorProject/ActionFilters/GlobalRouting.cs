using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TrashCollectorProject
{
    public class GlobalRouting : IActionFilter
    {
        private readonly ClaimsPrincipal _claimsPrincipal;
        public GlobalRouting(ClaimsPrincipal claimsPrincipal)
        {
            _claimsPrincipal = claimsPrincipal;
        }
        public void OnActionExicuting(ActionExecutingContext context)
        {
            var controller = context.RouteData.Values["controller"];
            if (_claimsPrincipal.IsInRole("Customer"))
            {
                context.Result = new RedirectToActionResult("Index",
                    "Customer", null);
            }
            else if (_claimsPrincipal.IsInRole("Employee"))
            {
                context.Result = new RedirectToActionResult("Index",
                    "Employees", null);
            }
        }
        public void OnActionExecuted(ActionExecutedContext context)
        {

        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
