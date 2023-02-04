using System.Text.Json.Serialization;

namespace LanguagePopularity.Reddit
{
    public class SubredditData
    {
        [JsonPropertyName("subscribers")]
        public int Subscribers { get; set; }

        [JsonPropertyName("title")]
        public string? Title { get; set; }
    }
}