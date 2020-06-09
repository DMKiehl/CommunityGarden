using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CommunityGardenProj.ActionFilters
{
    public class GlobalRouting : IActionFilter
    {
       
        private readonly ClaimsPrincipal _claimsPrincipal;

        public GlobalRouting(ClaimsPrincipal claimsPrincipal)
        {
            _claimsPrincipal = claimsPrincipal;
        }
        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.RouteData.Values["controller"];
            if (controller.Equals("Home"))
            {
                if (_claimsPrincipal.IsInRole("Gardener"))
                {
<<<<<<< HEAD
                    context.Result = new RedirectToActionResult("Index", "Gardeners", null);
=======
                    context.Result = new RedirectToActionResult("Create", "Gardeners", null);
>>>>>>> b20f333b6c72800774425b52aa1a930039d862e1
                }
                else if (_claimsPrincipal.IsInRole("Admin"))
                {
                    context.Result = new RedirectToActionResult("Index", "Admin", null);
                }
            }
          
        } 


        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
}
