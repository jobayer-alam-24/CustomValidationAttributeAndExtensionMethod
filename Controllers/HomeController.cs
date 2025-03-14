using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CustomValidationAttributeAndExtensionMethod.Models;

namespace CustomValidationAttributeAndExtensionMethod.Controllers;

public class HomeController : Controller
{

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Create(Employee employee)
    {
        if(ModelState.IsValid)
        {
            return View(employee);
        }
        else
        {
            return View(employee);
        }
    }
    
    public IActionResult Index()
    {
        var Employee = new Employee()
        {
            Name = "Rahim khan",
            Age = 15,
            DOB = DateTime.Now
        };
        return View(Employee);
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
