using HackerNews.Domain.Dtos.Story;

namespace HackerNews.Services.Interfaces
{
    public interface IHackerNewsService
    {
        Task<IEnumerable<StoryDto>> GetBest20HackerNews();
    }
}
