using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace dotnet_webapp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("report")]
        public IEnumerable<WeatherForecast> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .ToArray();
        }

        [HttpGet]
        [Route("album")]
        public string GetAlbum()
        {
            dynamic rootJSONObject = new JObject();
            rootJSONObject.Add("Enterted", DateTime.Now);
            rootJSONObject.AlbumName = "MyFirst Album";
            rootJSONObject.Artis = "Abhisherk";
            rootJSONObject.Relesed = 2020;

            rootJSONObject.Songs = new JArray() as dynamic;
            dynamic song = new JObject();
            song.SongName = "Dirty Deeds Done Dirt Cheap";
            song.SongLenght = "4:11";
            rootJSONObject.Songs.Add(song);

            song = new JObject();
            song.SongName = "Love at First Feel";
            song.SongLenght = "3:10";
            rootJSONObject.Songs.Add(song);
            
            return JsonConvert.SerializeObject(rootJSONObject);
            
        }
    }
}