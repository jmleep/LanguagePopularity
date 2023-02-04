using LanguagePopularity.Reddit;

while (true)
{
    Console.Write("Enter subreddit: ");
    string? inputSubreddit = Console.ReadLine();

    if (inputSubreddit != null)
    {
        var subreddit = await RedditAPI.RetrieveSubredditDataAsync(inputSubreddit);
        if (subreddit != null)
        {
            var subscribers = subreddit.Data.Subscribers.ToString("#,###");
            if (subscribers.Equals(""))
            {
                subscribers = "0";
            }

            Console.WriteLine($"\n{subreddit.Data.Title}");
            Console.WriteLine($"{subscribers} Subscribers\n");
        }
    }
}
