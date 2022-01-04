using Microsoft.VisualStudio.TestTools.UnitTesting;
using UmbrellaRecommenderApp;

namespace UmbrellaRecommenderTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void UmbrellaRecommender_ReturnsYes_IfRainy()
        {
            // Make weather service return a high probability value.
            var stub = new WeatherServiceStub();
            var recommender = new UmbrellaRecommender(stub);

            // probability > 80 means you definitely need to carry an umbrella.
            // Test the range between 81 and 100.
            for (var i = 81; i <= 100; i++)
            {
                stub.RainProbability = i;
                Assert.AreEqual(recommender.ShouldICarryUmbrella(), Recommendation.Yes);
            }
        }

        [TestMethod]
        public void UmbrellaRecommender_ReturnsMaybe_IfRainIsProbable()
        {
            // Make weather service return a medium probability value.
            var stub = new WeatherServiceStub();
            var recommender = new UmbrellaRecommender(stub);

            // probability > 40 and probability <= 80 means you may or may not need an umbrella.
            // Test the range between 41 and 80.
            for (var i = 41; i <= 80; i++)
            {
                stub.RainProbability = i;
                Assert.AreEqual(recommender.ShouldICarryUmbrella(), Recommendation.Maybe);
            }
        }

        [TestMethod]
        public void UmbrellaRecommender_ReturnsNo_IfRainIsNotProbable()
        {
            // Make weather service return a very low probability value.
            var stub = new WeatherServiceStub();
            var recommender = new UmbrellaRecommender(stub);

            // probability <= 40 means you don't need an umbrella.
            // Test the range between 0 and 40.
            for (var i = 0; i <= 40; i++)
            {
                stub.RainProbability = i;
                Assert.AreEqual(recommender.ShouldICarryUmbrella(), Recommendation.No);
            }
        }
    }
}
