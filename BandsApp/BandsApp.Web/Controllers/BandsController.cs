using BandsApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace BandsApp.Web.Controllers;

public class BandsController : Controller
{
    BandService bandService = new();

    [Route("/")]
    public IActionResult Index()
    {
        var bands = bandService.GetAllBands();
        return View(bands);
    }
}
