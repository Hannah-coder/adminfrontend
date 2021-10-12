using AdminFrontEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace AdminFrontEnd
{
    public class MonitoringAPIClient
    {
        public HttpClient _httpClient;

        public MonitoringAPIClient(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<IEnumerable<MerchandiseFilter>> GetMerchandiseFilter()
        {
            var response = await _httpClient.GetAsync("MerchandiseFilter");
            response.EnsureSuccessStatusCode();
            //var responseContent = await response.Content.ReadAsAsync<IEnumerable<MerchandiseFilter>>();

            return await response.Content.ReadAsAsync<IEnumerable<MerchandiseFilter>>();
        }
    }
}