using BLL.Concrete;
using DAL.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class UserController : Controller
    {
        //DEPENDENCY INJECTION KULLANIMI
        UserManager userManager = new UserManager(new UserRepository());
        // GET: User
        public ActionResult Index()
        {
            return View(userManager.GetAll());
        }
    }
}