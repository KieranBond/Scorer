namespace Scorer
{
    public interface IMetricsService
    {
        UserMetrics? GetUserMetrics(string username);
    }
}