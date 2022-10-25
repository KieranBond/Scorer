namespace Scorer
{
    public class MetricsService : IMetricsService
    {
        public UserMetrics GetUserMetrics(string username)
        {
            return new UserMetrics( username, "https://github.com/KieranBond" );
        }
    }
}
