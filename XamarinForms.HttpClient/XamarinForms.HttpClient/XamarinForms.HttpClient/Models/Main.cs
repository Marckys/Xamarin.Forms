using Newtonsoft.Json;

namespace XamarinForms.HttpClient.Models
{
    public class Main
    {

        [JsonProperty("temp")]
        public decimal Temp { get; set; }
        [JsonProperty("temp_min")]
        public decimal TempMin { get; set; }
        [JsonProperty("temp_max")]
        public decimal TempMax { get; set; }
    }
}