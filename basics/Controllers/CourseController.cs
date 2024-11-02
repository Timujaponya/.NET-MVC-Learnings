using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var courses = new List<Course>
        {
            new Course { Id = 1, Title = "C#", Description = "C# Kursu", Duration = 30, Image = "1.jpg" },
            new Course { Id = 2, Title = "ASP.NET", Description = "ASP.NET Kursu", Duration = 40, Image = "2.jpg" },
            new Course { Id = 3, Title = "SQL Server", Description = "SQL Server Kursu", Duration = 20, Image = "3.jpg" }
        };

        return View(courses);
    }
    public IActionResult List()
    {
        var courses = new List<Course>
        {
            new Course { Id = 1, Title = "C#", Description = "C# Kursu", Duration = 30, Image = "1.jpg" },
            new Course { Id = 2, Title = "ASP.NET", Description = "ASP.NET Kursu", Duration = 40, Image = "2.jpg" },
            new Course { Id = 3, Title = "SQL Server", Description = "SQL Server Kursu", Duration = 20, Image = "3.jpg" }
        };

        return View("CourseList", courses);
    }
}