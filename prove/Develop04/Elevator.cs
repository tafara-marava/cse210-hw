using Microsoft.VisualBasic;
public class Elevator
{
    public List<int> floorList;
    public bool doorOpen;

    public Elevator()
    {
        floorList = new List<int>();

        for (int i = 1; i <= 30; i++)
        {
            floorList.Add(i);
        }
    }
}