using Domain.Enums;
using Domain.ValueObjects.AtributosVOs;
using Domain.ValueObjects.EspeciesVOs;
using Domain.ValueObjects.EstilosDeCombateVOs;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Domain.ValueObjects.VidaVOs
{
    // Value Object imutável que representa os Pontos de Vida de um personagem
    public record VidaVO
    {
        public int VidaTotal { get; init; }

        public int DadosDeVidaEstilo { get; init; }

        public int EspecieBaseHP { get; init; }

        public int ConstituicaoCalc { get; init; }

        public int Nivel { get; init; }

        public IReadOnlyList<int> Rolagens { get; init; } = Array.Empty<int>();

        public int? MediaDosDados { get; init; }

        public ConjuntoAtributosVO Atributos { get; init; }

        private VidaVO() { }


        public static VidaVO CriarNivel1(EstilosDeCombateEstilosVO estilo, EspeciesVO especie,ConjuntoAtributosVO atributos)
        {
            int conMod = Math.Max(1, atributos.Atributos.Find(p => p.Nome == AtributosEnum.CONSTITUICAO).Modificador);

            return new VidaVO
            {
                Nivel = 1,
                DadosDeVidaEstilo = estilo.DadoDeVida,
                EspecieBaseHP = especie.PontosDeVidaBase,
                ConstituicaoCalc = conMod,
                VidaTotal = estilo.DadoDeVida + especie.PontosDeVidaBase + conMod,
                Rolagens = Array.Empty<int>(),
                MediaDosDados = null,
                Atributos = atributos
            };
        }


        public VidaVO SubirNivel(bool ehRolagem, int novoNivel, int conModNoNivelAlvo)
        {
            // Validações básicas
            if (novoNivel <= Nivel)
            {
                throw new ArgumentException("Novo nível deve ser maior que o nível atual");

            }

            if (novoNivel < 1)
            {
                throw new ArgumentException("Nível deve ser >= 1.");
            }


            int conMod = conModNoNivelAlvo;

            int mediaFixa = (DadosDeVidaEstilo / 2) + 1;


            int pvAtual = VidaTotal;

            var novasRolagens = new List<int>(Rolagens);

            for (int nv = Nivel + 1; nv <= novoNivel; nv++)
            {
                int valorDado = ehRolagem ? Random.Shared.Next(1, DadosDeVidaEstilo + 1) : mediaFixa;                             

                int ganhoNivel = valorDado + conMod;

                pvAtual += ganhoNivel;
                novasRolagens.Add(valorDado); 

            }

            // Retorna NOVA instância imutável com valores atualizados
            return this with
            {
                VidaTotal = pvAtual,
                Nivel = novoNivel,
                Rolagens = novasRolagens.ToImmutableArray(),
                ConstituicaoCalc = conMod,        // atualiza CON usado para próximos cálculos
                MediaDosDados = ehRolagem ? null : mediaFixa
            };
        }
    }
}