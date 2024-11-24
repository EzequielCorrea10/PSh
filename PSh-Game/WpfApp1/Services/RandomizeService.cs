using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using WpfApp1.Model;


namespace WpfApp1.Services
{
    public class RandomizeService
    {
        public async Task<RandomUser> GetRandomUser()
        {
            string apiUrl = "https://randomuser.me/api";

            using (HttpClient client = new HttpClient())
            {

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                response.EnsureSuccessStatusCode();

                string responseBody = await response.Content.ReadAsStringAsync();

                var randomUser = new RandomUser();

                var randomUserResponse = JsonConvert.DeserializeObject<RandomUserResponse>(responseBody);

                return randomUserResponse?.Results?.FirstOrDefault();

            }
        }

    }
}
