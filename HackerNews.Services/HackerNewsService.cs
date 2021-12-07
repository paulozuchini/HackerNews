using HackerNews.Domain.Constants;
using HackerNews.Domain.Dtos.Story;
using HackerNews.Services.Interfaces;
using Newtonsoft.Json;
using RestSharp;
using System.Diagnostics.CodeAnalysis;

namespace HackerNews.Services
{
    [ExcludeFromCodeCoverage]
    public class HackerNewsService : IHackerNewsService
    {
        public async Task<IEnumerable<StoryDto>> GetBest20HackerNews()
        {
            var request = await GetUrlRequest(HackerNewsConstants.BEST_STORIES);
            var client = new RestClient();
            var response = await client.ExecuteGetAsync<int[]>(request);

            HandleException(response);

            try
            {

                int[] stories = JsonConvert.DeserializeObject<int[]>(response.Content);

                List<StoryDto> result = new();

                foreach (var id in stories.Take(20))
                {
                    var _request = await GetUrlRequest(GetItemUrl(id));
                    var _response = await client.ExecuteGetAsync<StoryDto>(_request);

                    HandleException(_response);

                    var story = JsonConvert.DeserializeObject<StoryDto>(_response.Content);

                    result.Add(story);
                }

                return await Task.FromResult(result);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private static void HandleException(IRestResponse response)
        {
            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.NotFound:
                case System.Net.HttpStatusCode.BadRequest:
                case System.Net.HttpStatusCode.Unauthorized:
                case System.Net.HttpStatusCode.InternalServerError:
                    throw new Exception($"Status code: {(int)response.StatusCode} Error Message: {response.Content}");
            }
        }

        private static async Task<RestRequest> GetUrlRequest(string urlRequestPartial)
        {
            string url = string.Concat(HackerNewsConstants.BASE_URL, urlRequestPartial);
            RestRequest restClient = new(url);
            restClient.OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; };
            return await Task.FromResult(restClient);
        }

        private static string GetItemUrl(int id)
        {
            return string.Concat(HackerNewsConstants.ITEM_DETAIL_PREFIX, id, HackerNewsConstants.ITEM_DETAIL_SUFIX);
        }
    }
}
