using HackerNews.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace HackerNews.Controllers
{
    [Route("api/hackernews")]
    public class HackerNewsController : Controller
    {
        private readonly IHackerNewsService _service;
        private readonly ILogger<HackerNewsController> _logger;

        public HackerNewsController(IHackerNewsService service, ILogger<HackerNewsController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet]
        [Route("best20")]
        public async Task<IActionResult> GetBest20HackerNews()
        {
            try
            {
                return Ok(await _service.GetBest20HackerNews());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error api/hackernews/best20");
                return BadRequest(ex.Message);
            }
        }
    }
}