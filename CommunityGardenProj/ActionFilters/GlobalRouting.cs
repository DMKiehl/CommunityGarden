using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CommunityGardenProj.ActionFilters
{
    public class GlobalRouting:IActionFilters
    {
        private readonly ClaimsPrincipal claimsPrincipal;
        private ClaimsPrincipal _claimsPrincipal;

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
                    context.Result = new RedirectToActionResult("Index", "Gardener", null);
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
