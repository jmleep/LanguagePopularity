using SubSubs.Reddit;

while (true)
{
    Console.Write("Enter subreddit: ");
    string? inputSubreddit = Console.ReadLine();

    if (inputSubreddit != null)
    {
        var cleanedUpInput = inputSubreddit.Trim().ToLower();
        var subreddit = await RedditAPI.RetrieveSubredditDataAsync(cleanedUpInput);
        if (subreddit != null)
        {
            var subscribers = subreddit.Data.Subscribers.ToString("#,###");
            if (subscribers.Equals(""))
            {
                subscribers = "0";
            }

            Console.WriteLine($"\n{subreddit.Data.Title}");
            Console.WriteLine($"\nhttps://reddit.com/r/{cleanedUpInput}");
            Console.WriteLine($"{subscribers} Subscribers\n");
        }
    }
}
