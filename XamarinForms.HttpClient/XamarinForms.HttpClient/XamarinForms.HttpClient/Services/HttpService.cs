using System.Threading.Tasks;
using Newtonsoft.Json;
using XamarinForms.HttpClient.Models;

namespace XamarinForms.HttpClient.Services
{
    public class HttpService
    {
        public async Task<Weather> GetAsync(string url)
        {
            var data = "";
            using (var client = new System.Net.Http.HttpClient())
            {
                var response = await client.GetAsync(url);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    data = await response.Content.ReadAsStringAsync();
                }
            }
            return JsonConvert.DeserializeObject<Weather>(data);
        }
    }
}
