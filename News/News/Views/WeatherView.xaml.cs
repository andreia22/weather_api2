using News.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace News.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherView : ContentPage
    {
        public WeatherView()
        {
            InitializeComponent();
            Task.Run(async () => await Initialize("Weather"));
        }

        public WeatherView(string scope)
        {
            InitializeComponent();
            Title = $"{scope} news";
            Task.Run(async () => await Initialize(scope));
        }

        private async Task Initialize(string scope)
        {
            var viewModel = Resolver.Resolve<WeatherViewModel>();
            BindingContext = viewModel;
            await viewModel.Initialize(scope);
        }
    }
}
    
