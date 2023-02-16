using System.Text.Json.Serialization;

namespace SubSubs.Reddit.Model
{
    internal class Subreddit
    {
        [JsonPropertyName("data")]
        public SubredditData Data { get; set; }
    }
}
