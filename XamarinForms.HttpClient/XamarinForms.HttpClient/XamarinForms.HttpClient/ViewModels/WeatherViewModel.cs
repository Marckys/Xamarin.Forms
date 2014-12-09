

using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamarinForms.HttpClient.ViewModels
{

    public class WeatherViewModel : INotifyPropertyChanged
    {

        private string _Temp ;

        public string Temp
        {
            get
            {
                return _Temp;
            }
            set
            {
                _Temp = value;
                OnPropertyChanged();
            }
        }


        public async void LoadHttpTemp()
        {
            var serviceHttp = new Services.HttpService();
            var data = await serviceHttp.GetAsync("http://api.openweathermap.org/data/2.5/weather?q=BArcelona&units=metric");
            if (data != null) Temp = data.Main.Temp.ToString("00.##°C");
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
