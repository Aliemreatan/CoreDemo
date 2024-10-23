using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    [Area("Admin")]

    public class Statistic1 : ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = bm.GetList().Count();
            ViewBag.v2 = c.Contacts.Count();
            ViewBag.v3 = c.Comments.Count();

            //string api = "e2f14ad215e1a199269187fb03315783";
            //string connection = "https://api.openweathermap.org/data/2.5/weather?lat=44.34&lon=10.99&appid=" + api;

            //XDocument document = XDocument.Load(connection);
            //ViewBag.v4 = document.Descendants("temp").ElementAt(0).Attribute("temp_max");
			return View();
        }
    }
}
