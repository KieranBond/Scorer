using NUnit.Framework;
using FluentAssertions;

namespace Scorer.Tests
{
    public class MetricsServiceTests
    {
        private readonly MetricsService _metricsService = new();

        [Test]
        public void Provides_Correct_User_Information()
        {
            var result = _metricsService.GetUserMetrics("KieranBond");
            result.Username.Should().Be("KieranBond");
            result.PageUrl.Should().Be("https://github.com/KieranBond");
        }

        [Test]
        public void Handles_Bad_Username()
        {
            var result = _metricsService.GetUserMetrics("");
            result.Should().BeNull();

            result = _metricsService.GetUserMetrics(null);
            result.Should().BeNull();

            result = _metricsService.GetUserMetrics("         ");
            result.Should().BeNull();
        }
    }
}