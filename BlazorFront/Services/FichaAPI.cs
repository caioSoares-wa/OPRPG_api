using System.Collections.Generic;
using System.Net.Http.Json;
using Domain.ValueObjects.EspeciesVOs;
using Domain.ValueObjects.EstilosDeCombateVOs;
using Domain.ValueObjects.AntecedentesVOs;

namespace BlazorFront.Services
{
    public class FichaAPI
    {
        private readonly HttpClient _httpClient;

        public FichaAPI(IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient("API");
        }

        public async Task<List<EstilosDeCombateEstilosVO>> GetEstilosAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<EstilosDeCombateEstilosVO>>("api/estilos") ?? new();
            }
            catch
            {
                return new();
            }
        }

        public async Task<List<EspeciesVO>> GetEspeciesAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<EspeciesVO>>("api/especies") ?? new();
            }
            catch
            {
                return new();
            }
        }

        public async Task<List<AntecedentesVO>> GetAntecedentesAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<List<AntecedentesVO>>("api/antecedentes") ?? new();
            }
            catch
            {
                return new();
            }
        }

        public async Task<bool> CriarFichaAsync(object fichaData)
        {
            try
            {
                var response = await _httpClient.PostAsJsonAsync("api/ficha", fichaData);
                return response.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}