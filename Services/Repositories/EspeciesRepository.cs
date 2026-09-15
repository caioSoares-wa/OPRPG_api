using Services.DTOs.EspeciesDTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Services.Repositories
{
    public class EspeciesRepository
    {

        private readonly string _caminhoEspecie = "Data/Catalog/especies.json";
        private readonly string jsonEspecie;
        private readonly List<EspeciesDTO> TodasAsEspecies;

        public EspeciesRepository() {

            jsonEspecie = File.ReadAllText(_caminhoEspecie);

            if (jsonEspecie == null)
            {
                throw new Exception(nameof(jsonEspecie));
            }


            var options = new JsonSerializerOptions();
            options.PropertyNameCaseInsensitive = true;


            TodasAsEspecies = JsonSerializer.Deserialize<List<EspeciesDTO>>(jsonEspecie,options);
        }




        public EspeciesDTO BuscarPorNome(string nome)
        {

            var dto = TodasAsEspecies.First(p => p.Nome.ToUpper().Equals(nome.ToUpper()));
            if (dto == null)
            {
                throw new Exception(nameof(dto));
            }

            return dto;
        }



    }
}
