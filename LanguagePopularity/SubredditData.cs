using System.Text.Json.Serialization;

namespace LanguagePopularity
{
    public class SubredditData
    {
        [JsonPropertyName("subscribers")]
        public int Subscribers { get; set; }
    }
}