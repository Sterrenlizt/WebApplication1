using System.Net.Cache;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            var profile = new ProfileModel
            {
                Name = "Olivia Angeline Gallano",
                Age = 20,
                Education = "3rd year Computer Science Student at Polytechnic University of the Philippines",
                Tools = "After Effects, Capcut, Audacity, Visual Studio Code, Microsoft Visual Studio",
                Hobbies = "Gaming, Movie-watching, Video and Audio Editing, Occasional Coding",
                Interests = "Multimedia, Technology, Arts, basically combining arts and technology",
                ImagePath = "/images/pfp.jpg"
            };
            return View(profile);
        }
    }
}
