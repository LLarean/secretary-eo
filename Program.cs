using secretary;
using secretary.WeatherModule;

new Greeting(DateTime.Now).Message();
new Weather().Message();

Console.WriteLine("/nPress any key to exit");
Console.ReadKey();