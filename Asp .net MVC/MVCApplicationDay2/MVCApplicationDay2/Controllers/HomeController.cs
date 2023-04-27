using System.Web.Mvc;

namespace MVCApplicationDay2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(string id)
        {
            if (id == null)
            {
                return Content("<h1>This is a demo of ContentResult</h1>");
            } 
            else if (id.ToLower() == "plain")
            { 
                return Content("<h1>This is a demo of Plain ContentResult</h1>", "text/plain");
            }
            else if (id.ToLower() == "html")
            {
                return Content("<h1>This is a demo of html ContentResult</h1>", "text/html"); 
            }
            else if(id.ToLower() == "xml")
            {
                return Content("<h1>This is a demo of xml ContentResult</h1>", "text/xml"); 
            }
            return Content("Invalid content type");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult DownloadFile()
        {
            if (!System.IO.File.Exists(@"C:\Users\KAAUTI\Desktop\SampleImage.jpg"))
            {
                return Content("File to be downloaded not found");
            }
            return File(@"C:\Users\KAAUTI\Desktop\SampleImage.jpg", "image/jpg", "default.jpg");
        }
        public ActionResult Google()
        {
            return Redirect("http://www.google.com");
        }
        public ActionResult StartPage() 
        {
            return RedirectToAction("Index", new { id = "xml" });
        }

        public ActionResult Login()
        {
            return View();
        }
        public ActionResult AboutUs() { return View(); }
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}