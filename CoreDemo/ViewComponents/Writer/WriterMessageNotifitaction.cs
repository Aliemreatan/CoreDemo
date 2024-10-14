using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotifitaction : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
