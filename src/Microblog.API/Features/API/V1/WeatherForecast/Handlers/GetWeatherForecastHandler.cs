using MediatR;
using Microblog.API.Features.API.V1.WeatherForecast.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Microblog.API.Features.API.V1.WeatherForecast.Handlers
{
    public class GetWeatherForecastHandler : IRequestHandler<GetWeatherForecastQuery, List<WeatherForecast>>
    {
        // Inject repository here

        public Task<List<WeatherForecast>> Handle(GetWeatherForecastQuery request, CancellationToken cancellationToken)
        {
            var Summaries = new List<string>() {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            var rng = new Random();
            var result = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries.ElementAt(rng.Next(Summaries.Count()))
            })
            .ToList();

            return Task.FromResult(result);
        }
    }
}
