using Domain.Enums;
using Domain.ValueObjects.AtributosVOs;
using System;
using System.Collections.Generic;

namespace Domain.ValueObjects.PericiasVOs
{
    public record ConjuntoPericiasVO
    {
        public List<PericiasVO> Pericias { get; init; } = new();
        public PericiasProficientesVO PericiasProficientes { get; init; }

        public ConjuntoPericiasVO(ConjuntoAtributosVO atributos, List<PericiasEnum> periciasTreinadas)
        {
            int modForca = atributos.Atributos.Find(a => a.Nome == AtributosEnum.FORCA).Modificador;
            int modDestreza = atributos.Atributos.Find(a => a.Nome == AtributosEnum.DESTREZA).Modificador;
            int modSabedoria = atributos.Atributos.Find(a => a.Nome == AtributosEnum.SABEDORIA).Modificador;
            int modVontade = atributos.Atributos.Find(a => a.Nome == AtributosEnum.VONTADE).Modificador;
            int modPresenca = atributos.Atributos.Find(a => a.Nome == AtributosEnum.PRESENCA).Modificador;

            Pericias = new List<PericiasVO>
            {
                new PericiasVO(PericiasEnum.ATLETISMO, AtributosEnum.FORCA, modForca, null, false),
                new PericiasVO(PericiasEnum.ACROBACIA, AtributosEnum.DESTREZA, modDestreza, null, false),
                new PericiasVO(PericiasEnum.FURTIVIDADE, AtributosEnum.DESTREZA, modDestreza, null, false),
                new PericiasVO(PericiasEnum.PRESTIDIGITACAO, AtributosEnum.DESTREZA, modDestreza, null, false),
                new PericiasVO(PericiasEnum.HISTORIA, AtributosEnum.SABEDORIA, modSabedoria, null, false),
                new PericiasVO(PericiasEnum.INVESTIGACAO, AtributosEnum.SABEDORIA, modSabedoria, null, false),
                new PericiasVO(PericiasEnum.MEDICINA, AtributosEnum.SABEDORIA, modSabedoria, null, false),
                new PericiasVO(PericiasEnum.NATUREZA, AtributosEnum.SABEDORIA, modSabedoria, null, false),
                new PericiasVO(PericiasEnum.SOBREVIVENCIA, AtributosEnum.SABEDORIA, modSabedoria, null, false),
                new PericiasVO(PericiasEnum.HAKI, AtributosEnum.VONTADE, modVontade, null, false),
                new PericiasVO(PericiasEnum.INTUICAO, AtributosEnum.VONTADE, modVontade, null, false),
                new PericiasVO(PericiasEnum.PERCEPCAO, AtributosEnum.VONTADE, modVontade, null, false),
                new PericiasVO(PericiasEnum.SOBRENATURAL, AtributosEnum.VONTADE, modVontade, null, false),
                new PericiasVO(PericiasEnum.SORTE, AtributosEnum.VONTADE, modVontade, null, false),
                new PericiasVO(PericiasEnum.ATUACAO, AtributosEnum.PRESENCA, modPresenca, null, false),
                new PericiasVO(PericiasEnum.ENGANACAO, AtributosEnum.PRESENCA, modPresenca, null, false),
                new PericiasVO(PericiasEnum.INTIMIDACAO, AtributosEnum.PRESENCA, modPresenca, null, false),
                new PericiasVO(PericiasEnum.PERSUASAO, AtributosEnum.PRESENCA, modPresenca, null, false),
                new PericiasVO(PericiasEnum.PROVOCACAO, AtributosEnum.PRESENCA, modPresenca, null, false),
            };


        }
    }
}