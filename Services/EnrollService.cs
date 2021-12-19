using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using UAS.Models;

namespace UAS.Services
{
    public class EnrollService : IEnrollService
    {
        private HttpClient _httpClient;
        public EnrollService(HttpClient httpClient)
        {
           _httpClient = httpClient;
        }

        public async Task<IEnumerable<Enrollment>> GetById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<Enrollment>>($"enrollment/{id}");
            return result;
        }
    }
}