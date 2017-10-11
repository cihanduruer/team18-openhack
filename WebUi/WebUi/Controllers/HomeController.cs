using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebUi.Controllers
{
    public class HomeController : Controller
    {
        private static string url = "http://minecraftrconapi:8080/v1/object";
        //private static string url = "https://raw.githubusercontent.com/cihanduruer/team18-openhack/master/example.json";

        public async Task<IActionResult> Index()
        {
            var json = await ProcessApi();
            ViewBag.Json = json.Value;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        private static async Task<JsonResult> ProcessApi()
        {
            try
            {
                var client = new HttpClient();
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("User-Agent", "Minecraft Openhack .NET Core Client");

                var stringTask = await client.GetStringAsync(url);
                Console.Write("JSON: " + stringTask);
                return new JsonResult(stringTask);
            }
            catch (Exception ex)
            {
                Console.Write("JSON: " + ex.Message);
                return new JsonResult(ex.Message);
            }
        }

        
    }
    
    public class tenant
    {
        public string name;
        public List<Tuple<string, string>> endpoints;
    }


}
