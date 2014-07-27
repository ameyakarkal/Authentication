using System.Web.Mvc;
using System.Web.Security;

namespace BasicFormsAuthentication.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string username)
        {
            if (!string.IsNullOrEmpty(username))
            {
                FormsAuthentication.RedirectFromLoginPage(username, true);    
            }

            return View();
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();

            return RedirectToAction("index", "home");
        }
    }
}