using Scorer.Dto;

namespace Scorer.Services
{
    internal interface IApiFacade
    {
        User GetUser(string username);
    }
}
