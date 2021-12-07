using System.Diagnostics.CodeAnalysis;

namespace HackerNews.Domain.Dtos.Items
{
    [ExcludeFromCodeCoverage]
    public class ItemsDto
    {
        public int Id { get; set; }
        public bool Deleted { get; set; }
        public string Type { get; set; }
        public string By { get; set; }
        public long Time { get; set; }
        public string Text { get; set; }
        public bool Dead { get; set; }
        public int Parent { get;set; }
        public int Pool { get; set; }
        public int[] Kids { get; set; }
        public string Url { get; set; }
        public int Score { get; set; }
        public string Title { get; set; }
        public int[] Parts { get; set; }
        public int Descendants { get; set; }
    }
}
