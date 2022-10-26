using Octokit;

namespace Scorer
{
    public class MetricsService : IMetricsService
    {
        public UserMetrics GetUserMetrics(string username)
        {
            var github = new GitHubClient(new ProductHeaderValue("kb-scorer"));
            var user = github.User.Get(username).Result;

            return new UserMetrics(username, user.HtmlUrl);
        }
    }
}
