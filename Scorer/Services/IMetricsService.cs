using Scorer.Dto;

namespace Scorer.Services
{
    public interface IMetricsService
    {
        UserMetrics? GetUserMetrics(string username);
    }
}