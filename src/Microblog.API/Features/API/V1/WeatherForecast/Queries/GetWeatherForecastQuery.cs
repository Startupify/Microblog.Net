using MediatR;
using System.Collections.Generic;

namespace Microblog.API.Features.API.V1.WeatherForecast.Queries
{
    public class GetWeatherForecastQuery : IRequest<List<WeatherForecast>>
    {
    }
}
