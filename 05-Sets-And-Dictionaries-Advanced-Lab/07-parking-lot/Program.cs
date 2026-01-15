string command = "";
var parkingLot = new HashSet<string>();

while ((command = Console.ReadLine()) != "END")
{
    string[] parts = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

    string direction = parts[0];
    string carNumber = parts[1];

    if (direction == "IN")
    {
        parkingLot.Add(carNumber);
    }
    else if (direction == "OUT")
    {
        parkingLot.Remove(carNumber);
    }
}

if (parkingLot.Count == 0)
{
    Console.WriteLine("Parking Lot is Empty");
}
else
{
    foreach (var car in parkingLot)
    {
        Console.WriteLine(car);
    }
}