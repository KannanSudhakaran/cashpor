using FrontEndMVCApp.DTOs;
using FrontEndMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text.Json.Serialization;

namespace FrontEndMVCApp.Controllers
{
    public class HomeController : Controller
    {
       private readonly ILogger<HomeController> _logger;
       private readonly AppSettingsModel _conf;

        public HomeController(ILogger<HomeController> logger, AppSettingsModel config)
        {
            _logger=logger;

            _logger.LogCritical("home controller created");
            _conf=config;


        }

        public async Task<IActionResult> Index()
        {
            // var random = new Random();
            //var result= random.Next(1, 100);
            // if (result > 50)
            // {
            //     return View();
            // }

            // else
            // {
            //     return NotFound();
            //    // return Content("simple content value of result is "+result);
            // }


            var client = new HttpClient();
           var dataString = await client.GetStringAsync(_conf.Backend_api_url + "/WeatherForecast");

           var weatherInfoList= JsonConvert.DeserializeObject<List<WeatherForecastDTO>>(dataString);
            return View(weatherInfoList);

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
