string command = "";
var guests = new HashSet<string>();
bool partyStarted = false;

while ((command = Console.ReadLine()) != "END")
{
    if (command == "PARTY")
    {
        partyStarted = true;
    }
    else
    {
        if (partyStarted)
        {
            if (guests.Contains(command))
            {
                guests.Remove(command);
            }
        }
        else
        {
            guests.Add(command);
        }
    }
}

Console.WriteLine(guests.Count);

if (guests.Count > 0)
{
    var vip = guests.Where(g => char.IsDigit(g[0]));
    var regular = guests.Where(g => !char.IsDigit(g[0]));

    foreach (var guest in vip)
    {
        Console.WriteLine(guest);
    }

    foreach (var guest in regular)
    {
        Console.WriteLine(guest);
    }
}
