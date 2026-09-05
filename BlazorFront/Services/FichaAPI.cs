using System.Net.Http.Json;

namespace BlazorFront.Services
{
    public class FichaAPI
    {
        private readonly HttpClient _httpclient;

        public FichaAPI(IHttpClientFactory  factory)
        {
            _httpclient = factory.CreateClient("API");
        }

      
        //public async Task<ICollection<EspeciesResponse>> PegarTodasEspeciesAsync()
        //{

       //     return await _httpclient.GetFromJsonAsync<ICollection<EspeciesResponse>>("especies");
        //}

    }
}
