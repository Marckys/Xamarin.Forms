using Xamarin.Forms;
using XamarinForms.HttpClient.ViewModels;

namespace XamarinForms.HttpClient.Pages
{
    public partial class WeatherPage: ContentPage
    {
        private WeatherViewModel viewModel;
        
        public WeatherPage()
        {
            viewModel = new WeatherViewModel();
            BindingContext = viewModel;
            InitializeComponent();
           
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            viewModel.LoadHttpTemp();
        }
    }
}
