using Services.DTOs.AntecedentesDTOs;
using System.Text.Json;


namespace Services.Repositories
{
    public class AntecedenteRepository
    {

        private readonly string _caminhoArquivo = "Data/Catalog/antecedentes.json";
        private readonly string jsonAntecedente;
        private readonly List<AntecedentesDTO> TodosOsAntecedentesDTO;
        
        public AntecedenteRepository( )
        {

            jsonAntecedente = File.ReadAllText(_caminhoArquivo);

            if (jsonAntecedente == null)
            {
                throw new Exception(nameof(jsonAntecedente));
            }

            var options = new JsonSerializerOptions();
        
            options.PropertyNameCaseInsensitive = true;


            TodosOsAntecedentesDTO = JsonSerializer.Deserialize<List<AntecedentesDTO>>(jsonAntecedente, options);


            if (TodosOsAntecedentesDTO == null)
            {
                throw new NullReferenceException(nameof(TodosOsAntecedentesDTO));
            }



        }

        public AntecedentesDTO ObterPorNome(string nome)
        {
            AntecedentesDTO dto = TodosOsAntecedentesDTO.First(p => p.Nome.ToUpper().Equals(nome.ToUpper()));
            return dto;
        }

        


        }
}
