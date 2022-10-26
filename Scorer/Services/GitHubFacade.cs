using Octokit;

namespace Scorer.Services
{
    internal sealed class GitHubFacade : IApiFacade
    {
        private readonly GitHubClient _client;

        public GitHubFacade()
        {
            _client = new GitHubClient(new ProductHeaderValue("kb-scorer"));
        }

        public Dto.User GetUser(string username)
        {
            var result = _client.User.Get(username).Result;
            return new Dto.User(username, result.HtmlUrl);
        }
    }
}
