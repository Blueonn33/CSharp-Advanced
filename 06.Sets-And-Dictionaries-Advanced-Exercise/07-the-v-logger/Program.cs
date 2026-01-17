Dictionary<string, List<string>> influencers = new();
Dictionary<string, List<string>> following = new();

string input = Console.ReadLine();

while (input != "Statistics")
{
    string[] split = input.Split();
    string influencer = split[0];
    string command = split[1];

    if (command == "joined")
    {
        if (!influencers.ContainsKey(influencer))
        {
            influencers.Add(influencer, new List<string>());
            following.Add(influencer, new List<string>());
        }
    }
    else
    {
        string secondInfluencer = split[2];

        if (influencers.ContainsKey(influencer) && influencers.ContainsKey(secondInfluencer))
        {
            if (influencer != secondInfluencer &&
                !influencers[secondInfluencer].Contains(influencer))
            {
                influencers[secondInfluencer].Add(influencer);
                following[influencer].Add(secondInfluencer);
            }
        }
    }

    input = Console.ReadLine();
}

influencers = influencers
    .OrderByDescending(i => i.Value.Count)
    .ThenBy(i => following[i.Key].Count)
    .ToDictionary(i => i.Key, i => i.Value);

Console.WriteLine($"The V-Logger has a total of {influencers.Count} vloggers in its logs.");

int counter = 1;

foreach (var (influencer, followers) in influencers)
{
    Console.WriteLine($"{counter}. {influencer} : {followers.Count} followers, {following[influencer].Count} following");

    if (counter == 1)
    {
        foreach (var follower in followers.OrderBy(f => f))
        {
            Console.WriteLine($"*  {follower}");
        }
    }

    counter++;
}