using Scorer.Dto;

namespace Scorer.Services
{
    public class MetricsService : IMetricsService
    {
        private readonly IApiFacade _apiFacade;

        public MetricsService()
        {
            _apiFacade = new GitHubFacade();
        }

        public UserMetrics? GetUserMetrics(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return null;

            var user = _apiFacade.GetUser(username);

            return new UserMetrics(username, user.HtmlUrl);
        }
    }
}