using Microsoft.AspNetCore.Mvc;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/favorite_photos")]
    public ActionResult FavoritePhotos()
    {
      return View();
    }
  }
}