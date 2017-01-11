using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using scLInq.Domain;
using scLInq.WebUI.Models;

namespace scLInq.WebUI.Controllers
{
    public class LoginController : Controller
    {
        #region Login User
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(UserM login)
        {
            if (ModelState.IsValid)
            {

                db_scLInqEntities db = new db_scLInqEntities();
                var user = (from userlist in db.tbUsers
                            where userlist.Name == login.Name && userlist.Password == login.Password
                            select new
                            {
                                userlist.UserId,
                                userlist.Name,userlist.FirstName,userlist.LastName
                            }).ToList();
                if (user.FirstOrDefault() != null)
                {
                    Session["UserName"] = user.FirstOrDefault().FirstName + " " + user.FirstOrDefault().LastName;
                    Session["UserID"] = user.FirstOrDefault().UserId;
                    return Redirect("/LInq/MySpace");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login credentials.");
                }
            }
            return View(login);
        }

        #endregion
    }
}