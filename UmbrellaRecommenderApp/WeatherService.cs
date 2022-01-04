using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbrellaRecommenderApp
{
    public class WeatherService : IWeatherService
    {
        public int GetRainProbability()
        {
            var rainProbability = new Random().Next(0, 100);
            Console.WriteLine("Rain probability: " + rainProbability);
            // A probability percentage between 0 and 100.
            // 0 means no rain and 100 means raining for sure.
            return rainProbability;
        }
    }
}
