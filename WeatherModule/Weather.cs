using System.Net;

namespace secretary.WeatherModule;

public class Weather()
{
    public void Message()
    {
        try
        {
            var task = ConnectAsync();
            task.Wait();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }

    private async Task ConnectAsync()
    {
        var requestMessage = "https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={API key}";
        WebRequest request = WebRequest.Create(requestMessage);
        request.Method = "POST";
        WebResponse response = await request.GetResponseAsync();

        await using (Stream s = response.GetResponseStream())
        {
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                var answer = await reader.ReadToEndAsync();
            }
        }
        
        response.Close();
    }
}