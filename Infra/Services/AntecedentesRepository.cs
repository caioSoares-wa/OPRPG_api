using Domain.Interfaces;
using Domain.ValueObjects.AntecedentesVO;
using Infra.DTOs.DTOsAntecedentes;
using Infra.Mappers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;


namespace Infra.Services
{
        // JSON -> DTO -> objeto do domain
    public class AntecedentesRepository : IAntecedentesRepository
    {
        //guardamos o caminho do json
        private readonly string _Antecedentes;


        //construtor da classe 
        //recebe o caminho do json e guarda esse caminho
        public AntecedentesRepository(string antecedentes)
        {
            _Antecedentes = antecedentes;
        }


        //metodo responsavel por buscar todos os antecedentes 
        // quanto terminar retorna uma List<AntecedentesVO>
        public async Task<List<AntecedentesVO>> ObterTodosAntecedenteAsync()
        {
            //le todo o conteudo de forma assincrona 
            string jsonString = await File.ReadAllTextAsync(_Antecedentes);

            //cria uma configuração para desserializar o JSON
            var options = new JsonSerializerOptions
            {
               //ignora "CaseSensitive"
                PropertyNameCaseInsensitive = true,
            };


            
            //Converte JSON para um objeto
            var containerDTO = JsonSerializer.Deserialize<AntecedentesContainerDTO>(jsonString, options);



            //verifica se o container é nulo, se sim volta uma lista vazia para não quebrar o sistema
            if (containerDTO?.Antecedentes == null)
            {
                return new List<AntecedentesVO>();
            }


            //pegando a lista que veio do json
            //dando um select para executar o ToDOmain()
            //toDomain executa e retorna um Objeto completo de acordo com cada Antecedente
            //ToList() transforma em uma lista
            return containerDTO.Antecedentes.Select(dto => dto.ToDomain()).ToList();
            
        }
    }
}
