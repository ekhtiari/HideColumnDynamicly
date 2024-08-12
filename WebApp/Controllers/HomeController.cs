using System.Diagnostics;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;

namespace WebApp.Controllers;

public class HomeController(IWebHostEnvironment environment) : Controller
{
    public IActionResult Index()
    {
        var path = Path.Combine(environment.WebRootPath, "data.json");
        var json = System.IO.File.ReadAllText(path);
        var result = JsonSerializer.Deserialize<List<Main>>(json);
        return View(result);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}