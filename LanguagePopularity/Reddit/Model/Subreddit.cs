using System.Text.Json.Serialization;

namespace LanguagePopularity.Reddit.Model
{
    internal class Subreddit
    {
        [JsonPropertyName("data")]
        public SubredditData Data { get; set; }
    }
}
