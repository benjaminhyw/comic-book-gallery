using System;
using System.Web.Mvc;

namespace comicbookgallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Wednesday)
            {
                return Redirect("/");
            }
            return Content("Hello from the comic books controller!");
        }
    }
}
