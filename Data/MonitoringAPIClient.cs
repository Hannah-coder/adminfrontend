using AdminFrontEnd.Models;
using AdminFrontEnd.Pages;
using Microsoft.AspNetCore.Mvc;
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

        public async Task<IEnumerable<MerchandiseFilter>> GetMerchandiseByCategory(string category)
        {
            var response = await _httpClient.GetAsync($"MerchandiseFilter/ByCategory/{category}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<MerchandiseFilter>>();
        }

        public async Task<IEnumerable<string>> GetDistinctCategories()
        {
            var response = await _httpClient.GetAsync("MerchandiseFilter/Categories");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<string>>();
        }
        public async Task DeleteCategory(string category)
        {
            var response = await _httpClient.DeleteAsync($"MerchandiseFilter/DeleteAll/{category}");
        }

        public async Task<IEnumerable<UserAccounts>> GetAllUserAccounts()
        {
            var response = await _httpClient.GetAsync("UserAccount");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<UserAccounts>>();
        }

        public async Task<UserAccounts> GetUserAccount(int id)
        {
            var response = await _httpClient.GetAsync($"UserAccount/{id}");
            return (UserAccounts)await response.Content.ReadAsAsync<UserAccounts>();
        }

        public async Task CreateUserAccount(UserAccounts user)
        {
            var response = await _httpClient.PostAsJsonAsync("UserAccount", user);
        }

        public async Task<UserAccounts> UpdateById(UserAccounts user)
        {
            var response = await _httpClient.PutAsJsonAsync("UserAccount", user);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<UserAccounts>();
            //return await response.Content.ReadAsAsync<IEnumerable<UserAccounts>>();
        }

        public async Task DeleteUserAccount(int id)
        {
            var response = await _httpClient.DeleteAsync($"UserAccount/{id}");
        }
    }
}