using BookTIckets.Server.ReadModels;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookTIckets.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FlightController : ControllerBase
    {
        private readonly ILogger<FlightController> _logger;

        public FlightController(ILogger<FlightController> logger)
        {
            _logger = logger;
        }

        Random random =new Random();

        [HttpGet]
        public IEnumerable<FlightRm> Search() => new FlightRm[]
        {
            new (Guid.NewGuid(), "American Airlines", random.Next(100, 5000).ToString(), new TimePlaceRm("Los Angeles", DateTime.Now.AddHours(random.Next(1, 4))), new TimePlaceRm("Istanbul", DateTime.Now.AddHours(random.Next(5, 11))), random.Next(1, 200)),
            new (Guid.NewGuid(), "Delta Airlines", random.Next(120, 4500).ToString(), new TimePlaceRm("New York", DateTime.Now.AddHours(random.Next(1, 4))), new TimePlaceRm("Paris", DateTime.Now.AddHours(random.Next(6, 12))), random.Next(15, 80)),
            new (Guid.NewGuid(), "United Airlines", random.Next(150, 4800).ToString(), new TimePlaceRm("Chicago", DateTime.Now.AddHours(random.Next(1, 4))), new TimePlaceRm("London", DateTime.Now.AddHours(random.Next(7, 13))), random.Next(18, 220)),
            new (Guid.NewGuid(), "Southwest Airlines", random.Next(110, 4200).ToString(), new TimePlaceRm("Houston", DateTime.Now.AddHours(random.Next(1, 4))), new TimePlaceRm("Toronto", DateTime.Now.AddHours(random.Next(8, 14))), random.Next(17, 350)),
            new (Guid.NewGuid(), "JetBlue Airways", random.Next(130, 4600).ToString(), new TimePlaceRm("San Francisco", DateTime.Now.AddHours(random.Next(1, 4))), new TimePlaceRm("Tokyo", DateTime.Now.AddHours(random.Next(9, 15))), random.Next(19, 430)),
            new (Guid.NewGuid(), "Alaska Airlines", random.Next(140, 4900).ToString(), new TimePlaceRm("Seattle", DateTime.Now.AddHours(random.Next(1, 4))), new TimePlaceRm("Beijing", DateTime.Now.AddHours(random.Next(10, 16))), random.Next(160, 410)),
            new (Guid.NewGuid(), "Spirit Airlines", random.Next(160, 4700).ToString(), new TimePlaceRm("Miami", DateTime.Now.AddHours(random.Next(1, 4))), new TimePlaceRm("Dubai", DateTime.Now.AddHours(random.Next(11, 17))), random.Next(220, 400)),
            new (Guid.NewGuid(), "Frontier Airlines", random.Next(170, 4300).ToString(), new TimePlaceRm("Denver", DateTime.Now.AddHours(random.Next(1, 4))), new TimePlaceRm("Munich", DateTime.Now.AddHours(random.Next(12, 18))), random.Next(230, 420)),
            new (Guid.NewGuid(), "Hawaiian Airlines", random.Next(180, 4400).ToString(), new TimePlaceRm("Honolulu", DateTime.Now.AddHours(random.Next(1, 4))), new TimePlaceRm("Sydney", DateTime.Now.AddHours(random.Next(13, 19))), random.Next(250, 330)),
            new (Guid.NewGuid(), "Allegiant Air", random.Next(190, 4500).ToString(), new TimePlaceRm("Las Vegas", DateTime.Now.AddHours(random.Next(1, 4))), new TimePlaceRm("Amsterdam", DateTime.Now.AddHours(random.Next(14, 20))), random.Next(260, 450))
        };
    }
}
