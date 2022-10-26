using Scorer;
using Scorer.Services;

Console.WriteLine("Welcome to Scorer!");
Console.WriteLine("We'll be helping you analyse your teams metrics, in the form of contributions in GitHub.");

Console.WriteLine("Please hold...");
Task.Delay(2000).Wait();
Console.Write("Please input a GitHub username: ");
var username = Console.ReadLine();

while (string.IsNullOrWhiteSpace(username))
{
    Console.WriteLine("That's not a valid user.");
    Console.Write("Please input a valid GitHub username: ");
    username = Console.ReadLine();
}

var metricService = new MetricsService();
var userMetrics = metricService.GetUserMetrics(username);

if (userMetrics != null)
{
    Console.WriteLine($"Username: {userMetrics?.Username}, User page URL: {userMetrics?.PageUrl}");
}
else
{
    Console.WriteLine($"Unable to find User with username: '{username}'");
}