using System.Reflection.Metadata.Ecma335;

class SmartDevice{
    bool canturnon;
    bool isOn;
    int TimeOn;
    string name; 

}

class SmartLight : SmartDevice{

}

class SmartHeater : SmartDevice{

}

class House{
    List<string> rooms = new List<string>();

    public void AddRoom(Rooms room)
    {
        Console.WriteLine("Please enter a room");
        string RoomName = Console.ReadLine();
        rooms.Add(RoomName);
    }

}
