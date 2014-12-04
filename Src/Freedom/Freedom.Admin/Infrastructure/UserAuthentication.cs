using Freedom.Admin.Models.Menus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Freedom.Admin.Infrastructure
{
    public class UserAuthenticationAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            //base.OnAuthorization(filterContext);
            filterContext.Controller.ViewBag.Menus = new MenuModel();
           
        }
    }
}