using Domain.ValueObjects;
using Infra.DTOs.DTosEspecies;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Mappers
{
    public static class EspeciesMapper
    {
        public static EspeciesVO ToDomain(this EspeciesDTO dto)
        {

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
                TracosDasEspecies = new EspeciesTracoDasEspeciesVO
                {
                    Beneficios = dto.TracosDasEspecies.Beneficios.Select(beneficiosDTO => new EspeciesTracoDasEspeciesBeneficioVO
                    {
                        Nome = beneficiosDTO.Nome,
                        Descricao = beneficiosDTO.Descricao,
                    }).ToList(),

                    Dificuldades = dto.TracosDasEspecies.Dificuldades.Select(dificuldadesDTO => new EspeciesDificuldadesVO
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

        private static EspeciesTracosCulturaisVO ToDomain(this EspeciesTracosCulturaisDTO dto)
        {
            return new EspeciesTracosCulturaisVO { Descricao = dto.Descricao };

        }
       

        private static EspeciesVarianteDaEspecieVO ToDomain(this EspeciesVarianteDaEspecieDTO dto){

            return new EspeciesVarianteDaEspecieVO
            {
                Descricao = dto.Descricao,
                Opcoes = dto.Opcoes.Select(opcaoDTO => new EspeciesVarianteDaEspecieOpcoesVO
                {

                    Nome = opcaoDTO.Nome,
                    Beneficios = new EspeciesVarianteDaEspecieOpcoesBeneficiosVO
                    {
                        Nome = opcaoDTO.Beneficios.Nome,
                        Descricao = opcaoDTO.Beneficios.Descricao,
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
