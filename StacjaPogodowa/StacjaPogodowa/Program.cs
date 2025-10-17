// See https://aka.ms/new-console-template for more information


using Database;

Console.WriteLine("Hello, World!"); 
Console.ReadKey();
Weather weather1 = new Weather();
Weather weather5= new Weather();
weather5= ChangeWeather(weather1);


Weather ChangeWeather(Weather weather)
{
    var objectToChange = new Weather();
    Console.WriteLine($"Weather measured by: {weather.MeasuredBy}");
    weather.MeasuredBy = "Jan Kowalski";
    Console.WriteLine($"Weather measured by:{weather.MeasuredBy}");
    return objectToChange;
}

