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
                TracoCultural = new EspeciesTracosCulturaisVO
                {
                    Descricao = dto.TracoCultural.Descricao
                },
                VarianteDaEspecie = new EspeciesVarianteDaEspecieVO
                {
                    Descricao = dto.VarianteDaEspecie.Descricao,
                    Opcoes = dto.VarianteDaEspecie.Opcoes.Select(opcaoDTO => new EspeciesVarianteDaEspecieOpcoesVO
                    {

                        Nome = opcaoDTO.Nome,
                        Beneficios = new EspeciesVarianteDaEspecieOpcoesBeneficiosVO
                        {
                            Nome = opcaoDTO.Beneficios.Nome,
                            Descricao = opcaoDTO.Beneficios.Descricao,
                        }
                    }).ToList()


                },
                Ancestralidade = new EspeciesAncestralidadeVO
                {
                    Descricao = dto.Ancestralidade.Descricao,
                },
                RegrasEspeciais = dto.RegrasEspeciais.Select(regrasDTO => new EspeciesRegrasEspeciaisVO
                {
                    Nome = regrasDTO.Nome,
                    Descricao = regrasDTO.Descricao,
                }).ToList(),

                






            };



            
        }
    }
}
