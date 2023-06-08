using News.Models;
using News.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Input;
using Xamarin.Forms;

namespace News.ViewModels
{
    internal class WeatherViewModel : ViewModel
    {
        private readonly WeatherService weatherService;

        public WeatherResult CurrentNews { get; set; }

        public WeatherViewModel(WeatherService weatherService)
        {
            this.weatherService = weatherService;
        }

        public async Task Initialize(string scope)
        {
            var resolvedScope = scope.ToLower() switch
            {
                "weather" => NewsScope.Weather,
                "headlines" => NewsScope.Headlines,
                _ => NewsScope.Headlines

            };

            await Initialize(resolvedScope);
        }

        public async Task Initialize(NewsScope scope)
        {
            CurrentNews = await weatherService.GetWeather(scope);
        }

        public ICommand ItemSelected =>
            new Command(async (selectedItem) =>
            {
                var selectedArticle = selectedItem as Article;
                var url = HttpUtility.UrlEncode(selectedArticle.Url);
                await Navigation.NavigateTo($"articleview?url={url}");
            });
    }
}
