using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Web;
using business_logic_Library;
using static business_logic_Library.LocationAnalysis;

namespace Assign3part3.Controllers
{
    public class HomeController : Controller
    {

        //[HttpGet]
        //public String Index()
        //{
        //    return "hello";
        //}
        //[HttpGet]
        //public int Echo([FromQuery]int i)
        //{
        //    return i;
        //}
        //[HttpGet]
        //public int Multiply(int i, int j)
        //{
        //    return i * j;
        //}
        //[HttpGet]
        //public int Subtract(int i, int j)
        //{
        //    return i - j;
        //}
        ///*
        //[HttpGet]
        //public String HaveWeMet(double lat, double lon, System.DateTime time)
        //{

        //    return;
        //}
        //[HttpGet]
        //public List<Location> checkAlibi(WhereWhen[] person, DateTime startTime, DateTime endTime)
        //{

        //    return;
        //}*/

        public class ZZZ
        {
            public string name;
            public int age;
        }

        [HttpPost]
        public ActionResult<int> DoThing([FromBody]ZZZ thing)
        {
            return thing.name.Length;
        }

    //    [HttpPost]
    //    public ActionResult<bool> AreMeeting([FromBody]AreMeetingRequest request)
    //{
    //    bool TorF = LocationAnalysis.AreMeeting(request.a, request.b, request.distanceMeter, request.timeSpan);

    //    return TorF;
    //}

    
    //    /*
    //     * public Location LocationOut()
    //    {
    //        double lat = 2.4 ;
    //        double lon = 2.4 ;
    //        return business_logic_Library.Location(lat,lon);
    //    }
    //    */

    }

    ///*
    //private static readonly string[] Summaries = new[]
    //{
    //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    //};

    //private readonly ILogger<WeatherForecastController> _logger;

    //public WeatherForecastController(ILogger<WeatherForecastController> logger)
    //{
    //    _logger = logger;
    //}

    //[HttpGet]
    //public IEnumerable<WeatherForecast> Get()
    //{
    //    var rng = new Random();
    //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //    {
    //        Date = DateTime.Now.AddDays(index),
    //        TemperatureC = rng.Next(-20, 55),
    //        Summary = Summaries[rng.Next(Summaries.Length)]
    //    })
    //    .ToArray();
    //}*/

}
