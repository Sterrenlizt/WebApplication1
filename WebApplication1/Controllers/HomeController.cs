using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Portfolio()
        {
            var portfolioViewModel = new Portfolio_View_Model.ProfileModel
            {
                Projects = new List<Portfolio_View_Model.ProjectItem>
                {
                    new Portfolio_View_Model.ProjectItem
                    {
                        Id = 1,
                        Title = "CirculatePH",
                        Subtitle = "Emergency Blood Coordination Platform",
                        Description = "Developed for the CodeKada 2026 Hackathon as part of Team Dos Tres. A digital platform designed to streamline emergency blood coordination and donor matching.",
                        TechStack = new List<string> { "ASP.NET Core MVC", "C#", "SQL Server", "Bootstrap" },
                        Category = "Hackathon / Health Technology",
                        Url = "https://drive.google.com/drive/folders/1KFCJ8u2IWVqE1wMqVDtbaeN-R1lM89gZ"
                    },
                    new Portfolio_View_Model.ProjectItem
                    {
                        Id = 2,
                        Title = "BioTrackPH",
                        Subtitle = "Interactive Environmental Monitoring Application",
                        Description = "An interactive environmental monitor designed to track and visualize Net Primary Productivity (NPP) trends across ecological sites in the Philippines.",
                        TechStack = new List<string> { "Typescript", "JavaScript", "HTML" },
                        Category = "Environmental Web Application / Data Visualization",
                        Url = "https://biotrack-ph.figma.site/"
                    }
                }
            };

            return View(portfolioViewModel);
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
}