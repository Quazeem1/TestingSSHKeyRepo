using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDemoUI.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());

            //var forecasts = Enumerable.Range(1, 5).Select(index =>
            //{
            //    // Create a new WeatherForecast object
            //    var forecast = new WeatherForecast
            //    {
            //        // Set the date by adding the current index to the start date
            //        Date = startDate.AddDays(index),

            //        // Generate a random temperature between -20 and 55 degrees Celsius
            //        TemperatureC = rng.Next(-20, 55),

            //        // Select a random weather summary from the predefined array
            //        Summary = Summaries[rng.Next(Summaries.Length)]
            //    };

            //    // Return the forecast
            //    return forecast;
            //}).ToArray(); // Convert the sequence of forecasts into an array

            //// Wrap the array in a completed Task and return
            //return Task.FromResult(forecasts);
        }

        
    }



}
