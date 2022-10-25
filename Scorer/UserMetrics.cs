namespace Scorer
{
    public sealed class UserMetrics
    {
        public readonly string Username;
        public readonly string PageUrl;

        public UserMetrics( string username, string pageUrl )
        {
            Username = username;
            PageUrl = pageUrl;
        }
    }
}