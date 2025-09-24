namespace secretary;

public class Greeting(DateTime dataTime)
{
    public void Message()
    {
        Console.WriteLine($"Welcome! Today is {dataTime.DayOfWeek}, {dataTime:D}");
    }
}