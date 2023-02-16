using SubSubs.Reddit.Model;
using System.Text.Json;

namespace SubSubs.Reddit
{
    internal static class RedditAPI
    {
        private static readonly HttpClient client = new();

        internal static async Task<Subreddit?> RetrieveSubredditDataAsync(string subreddit)
        {
            try
            {
                var subredditTask = client.GetStreamAsync($"https://www.reddit.com/r/{subreddit}/about.json");
                var subredditResults = await JsonSerializer.DeserializeAsync<Subreddit>(await subredditTask);
                return subredditResults;
            }
            catch (Exception e)
            {
                if (e.Message.Contains("404"))
                {
                    Console.WriteLine("Subreddit not found.\n");
                }
                else
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace?.ToString());
                }
            }

            return null;
        }
    }
}