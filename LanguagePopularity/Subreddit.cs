using System.Text.Json.Serialization;

namespace LanguagePopularity
{
    internal class Subreddit
    {
        [JsonPropertyName("data")]
        public SubredditData Data { get; set; }
    }
}
