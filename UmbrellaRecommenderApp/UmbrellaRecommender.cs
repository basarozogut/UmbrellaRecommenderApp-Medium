using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UmbrellaRecommenderApp
{
    public class UmbrellaRecommender
    {
        private IWeatherService _weatherService;

        public UmbrellaRecommender(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public Recommendation ShouldICarryUmbrella()
        {
            var rainProbability = _weatherService.GetRainProbability();

            if (rainProbability > 80)
                return Recommendation.Yes;
            else if (rainProbability > 40)
                return Recommendation.Maybe;
            else
                return Recommendation.No;
        }
    }
}
