using Services.DTOs.Estilos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Services.Repositories
{
    public class EstilosRepository
    {

        private readonly string caminhoEstilos = "Data/Catalog/estilos.json";
        private readonly string jsonEstilos ;

        public List<EstilosDTO> TodosOsEstilos;


        public EstilosRepository() {
            
            jsonEstilos = File.ReadAllText(caminhoEstilos);

            if (jsonEstilos == null)
            {
                throw new Exception(nameof(jsonEstilos));
            }

            var options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;

            TodosOsEstilos = JsonSerializer.Deserialize<List<EstilosDTO>>(jsonEstilos,options);

            if (TodosOsEstilos == null)
            {
                throw new Exception(nameof(TodosOsEstilos));
            }


        }


        public EstilosDTO BuscarPorNome(string nome)
        {

            var Estilo = TodosOsEstilos.First(p=> p.Nome.ToUpper().Equals(nome.ToUpper() ) );
            if (Estilo == null )
            {
                throw new Exception(nameof(Estilo));
            }

            return Estilo;
        }

    }
}
