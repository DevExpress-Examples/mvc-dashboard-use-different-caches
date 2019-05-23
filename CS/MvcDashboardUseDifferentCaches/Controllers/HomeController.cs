using System.Web.Mvc;

namespace MvcDashboardUseDifferentCaches.Controllers
{
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }
        public ActionResult Refresh() {
            CacheManager.ResetCache();
            return new EmptyResult();
        }
    }
}