using System.Diagnostics.CodeAnalysis;

namespace HackerNews.Domain.Dtos.Users
{
    [ExcludeFromCodeCoverage]
    public class Users
    {
        public int Id { get; set; }
        public long Created { get; set; }
        public int Karma { get; set; }
        public string About { get; set; }
        public int[] Submitted { get; set; }
    }
}
