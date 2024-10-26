using ApiFrontend.Models;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using System.Diagnostics;
using System.Net;
using System.Text.Json.Serialization;

namespace ApiFrontend.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string url = "https://localhost:7116/api/Api";
            using (WebClient web = new WebClient())
            {
                string Jsonstring = web.DownloadString(url);
                List<Event> events = JsonConvert.DeserializeObject<List<Event>>(Jsonstring);
                return View(events);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

      
    }
}