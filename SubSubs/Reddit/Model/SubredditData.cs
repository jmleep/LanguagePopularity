using System.Text.Json.Serialization;

namespace SubSubs.Reddit
{
    public class SubredditData
    {
        [JsonPropertyName("subscribers")]
        public int Subscribers { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }
    }
}