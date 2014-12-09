

using Newtonsoft.Json;

namespace XamarinForms.HttpClient.Models
{
    public class Weather
    {
        [JsonProperty("main")]
        public Main Main { get; set; }
    }
}
