using Domain.Interfaces;
using Domain.ValueObjects.EspeciesVOs;
using Infra.DTOs.DTosEspecies;
using Infra.Mappers;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Infra.Services
{
    public class EspeciesRepository : IEspeciesRepository
    {
        //pega o caminho do arquivo de especies
        private readonly string _Especies;

        //armazena esse caminho pelo construtor
        public EspeciesRepository(string especies)
        {
            _Especies = especies;
        }

        //Metodo que retorna todas as especies
        public async Task<List<EspeciesVO>> ObterTodasEspeciesAsync()
        {

            // vai no arquivo passado e le tudo de forma assincrona, depois coloca em uma string
            string jsonString = await File.ReadAllTextAsync(_Especies);


            //opção para ser case insentive Caio e caio vai ser o mesmo obj
            var options = new JsonSerializerOptions { 
                PropertyNameCaseInsensitive = true,
            };


            //transforma o json em um objeto especiescontainerDTO 
            var containerDTO = JsonSerializer.Deserialize<EspeciesContainerDTO>(jsonString,options);

            //se for nulo volta uma lista vazia para n quebrar o programa
            if (containerDTO == null)
            {
                return new List<EspeciesVO>();
            }

            //retorna todas as especies de acordo com o containerDTO
            return containerDTO.Especies.Select(esp => esp.ToDomain()).ToList(); ;
        }
    }
}
