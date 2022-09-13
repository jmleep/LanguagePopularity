using System.Text.Json;

namespace LanguagePopularity
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter subreddit: ");
                string? inputSubreddit = Console.ReadLine();

                if (inputSubreddit != null)
                {
                    var subreddit = await RetrieveSubredditDataAsync(inputSubreddit);
                    if (subreddit != null)
                    {
                        var subscribers = subreddit.Data.Subscribers.ToString("#,###");
                        if (subscribers.Equals(""))
                        {
                            subscribers = "0";
                        }

                        Console.WriteLine($"{subscribers} Subscribers\n");
                    }
                }
            }
        }

        private static async Task<Subreddit?> RetrieveSubredditDataAsync(string subreddit)
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
                }
            }

            return null;
        }
    }
}