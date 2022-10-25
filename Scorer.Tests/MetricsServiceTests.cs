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
    }
}