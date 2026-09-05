using Infra.DTOs.DTosEspecies;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.ValueObjects.EspeciesVOs;

namespace Infra.Mappers
{
    //classe estatica, que não pode ser instanciada
    public static class EspeciesMapper
    {

        //extension method: o "this EspeciesDTO dto " permite chamar dto.ToDomain() em vez de EspecieMapper.ToDomain(dto)
        public static EspeciesVO ToDomain(this EspeciesDTO dto)
        {

            //tranforma os dados que o repositorio passou e transforma em um objeto do dominio (no caso especies)
            return new EspeciesVO
            {
                Nome = dto.Nome,
                AjusteDeAtributo = dto.AjusteDeAtributo,
                Preconceito = dto.Preconceito,
                PontosDeVidaBase = dto.PontosDeVidaBase,
                Tamanho = new EspeciesTamanhoVO
                {
                    Categoria = dto.Tamanho.Categoria,
                    Faixa = dto.Tamanho.Faixa
                },
                Peso = new EspeciesPesoVO
                {
                    Faixa = dto.Peso.Faixa,
                },
                DeslocamentoMetros = dto.DeslocamentoMetros,
                NadoMetros = dto.NadoMetros,
                TracosDaEspecie = new EspeciesTracosDaEspecieVO
                {
                    Beneficios = dto.TracosDaEspecie.Beneficios.Select(beneficiosDTO => new EspeciesTracosDaEspecieBeneficioVO
                    {
                        Nome = beneficiosDTO.Nome,
                        Descricao = beneficiosDTO.Descricao,
                    }).ToList(),

                    Dificuldades = dto.TracosDaEspecie.Dificuldades.Select(dificuldadesDTO => new EspeciesDificuldadesVO
                    {
                        Nome= dificuldadesDTO.Nome,
                        Descricao= dificuldadesDTO.Descricao,

                    }).ToList()

                },
                TracoCultural = dto.TracoCultural?.ToDomain(),
                VarianteDaEspecie = dto.VarianteDaEspecie?.ToDomain(),
                Ancestralidade = dto.Ancestralidade?.ToDomain(),
                RegrasEspeciais = dto.RegrasEspeciais.Select(regrasDTO => new EspeciesRegrasEspeciaisVO
                {
                    Nome = regrasDTO.Nome,
                    Descricao = regrasDTO.Descricao,
                }).ToList(),

                







            };
        }

        //segundo metodo com o mesmo nome, so que é acionado quando alguem chama o .ToDomain() em um DTO da EspecieTracosCulturaisDTO
        private static EspeciesTracosCulturaisVO ToDomain(this EspeciesTracosCulturaisDTO dto)
        {
            return new EspeciesTracosCulturaisVO { Descricao = dto.Descricao };

        }

        //terceiro metodo com o mesmo nome, so que é acionado quando alguem chama o .ToDomain() em um DTO da EspeciesVarianteDaEspecieDTO
        private static EspeciesVarianteDaEspecieVO ToDomain(this EspeciesVarianteDaEspecieDTO dto){

            return new EspeciesVarianteDaEspecieVO
            {
                Descricao = dto.Descricao,
                Opcoes = dto.Opcoes.Select(opcaoDTO => new EspeciesVarianteDaEspecieOpcoesVO
                {

                    Nome = opcaoDTO.Nome,
                    Beneficio = new EspeciesVarianteDaEspecieOpcoesBeneficiosVO
                    {
                        Nome = opcaoDTO.Beneficio.Nome,
                        Descricao = opcaoDTO.Beneficio.Descricao,
                    }
                }).ToList()
            };
           

        }


        private static EspeciesAncestralidadeVO ToDomain(this EspeciesAncestralidadeDTO dto)
        {

            return new EspeciesAncestralidadeVO { Descricao = dto.Descricao };
        }

    }
}
