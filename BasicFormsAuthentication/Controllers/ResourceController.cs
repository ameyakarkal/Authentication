using System.Web.Mvc;

namespace BasicFormsAuthentication.Controllers
{
    public class ResourceController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}