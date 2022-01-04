using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbrellaRecommenderApp
{
    public class WeatherServiceStub : IWeatherService
    {
        public int RainProbability { get; set; }

        public int GetRainProbability()
        {
            return RainProbability;
        }
    }
}
