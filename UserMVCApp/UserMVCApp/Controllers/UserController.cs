using Microsoft.AspNetCore.Mvc;

public class UserController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(User user)
    {
        return View("Result", user);
    }
}