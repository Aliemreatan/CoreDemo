using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterAboutOnDashboard : ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());

        
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            //var user = await _usermanager.FindByNameAsync(User.Identity.Name);
            var username = User.Identity.Name;
            ViewBag.veri = username;
            var  usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var writerID = c.Writers.Where(x => x.WriterMail == usermail)
                .Select(y => y.WriterId)
                .FirstOrDefault();

            var values = wm.GetWriterById(writerID);
            return View(usermail);
        }
    }
}
