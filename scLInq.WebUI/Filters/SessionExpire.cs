using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace scLInq.WebUI.Filters
{
    public class SessionExpire : ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {

           if (HttpContext.Current.Session["UserName"]==null)
            {
                FormsAuthentication.SignOut();
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary { { "action", "Login" }, { "controller", "Login" }, { "returnUrl", filterContext.HttpContext.Request.RawUrl } });
                return;
            }
        }
        
    }
}