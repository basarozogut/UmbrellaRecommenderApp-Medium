using System;

namespace UmbrellaRecommenderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new UmbrellaRecommender(new WeatherService()).ShouldICarryUmbrella());
        }
    }
}
