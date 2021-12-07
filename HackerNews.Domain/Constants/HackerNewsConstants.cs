using System.Diagnostics.CodeAnalysis;

namespace HackerNews.Domain.Constants
{
    [ExcludeFromCodeCoverage]
    public static class HackerNewsConstants
    {
        public const string BASE_URL = "https://hacker-news.firebaseio.com/v0/";
        public const string BEST_STORIES = "beststories.json";
        public const string ITEM_DETAIL_PREFIX = "item/";
        public const string ITEM_DETAIL_SUFIX = ".json";
    }
}
