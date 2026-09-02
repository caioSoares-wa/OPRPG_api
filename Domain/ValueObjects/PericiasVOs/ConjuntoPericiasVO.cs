using Domain.Enums;
using Domain.ValueObjects.AtributosVOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.PericiasVOs
{
    public record ConjuntoPericiasVO
    {

        

        public List<PericiasVO> Pericias = new();


        public ConjuntoPericiasVO(ConjuntoAtributosVO atributos, IEnumerable<PericiasEnum> periciasTreinadas) {

            int modForca =  atributos.Atributos.Find(a => a.Nome == AtributosEnum.FORCA).Modificador;
            int modDestreza = atributos.Atributos.Find(a => a.Nome == AtributosEnum.DESTREZA).Modificador;
            int modSabedoria = atributos.Atributos.Find(a => a.Nome == AtributosEnum.SABEDORIA).Modificador;
            int modVontade = atributos.Atributos.Find(a => a.Nome == AtributosEnum.VONTADE).Modificador;
            int modPresenca = atributos.Atributos.Find(a => a.Nome == AtributosEnum.PRESENCA).Modificador;

            Pericias = new List<PericiasVO>
            {
                new PericiasVO("Atletismo", AtributosEnum.FORCA,modForca, null, false),
                new PericiasVO("Acrobacia", AtributosEnum.DESTREZA,modDestreza, null, false),
                new PericiasVO("Furtividade", AtributosEnum.DESTREZA,modDestreza, null, false),
                new PericiasVO("Prestidigitação" ,AtributosEnum.DESTREZA,modDestreza, null, false),

                new PericiasVO("História",AtributosEnum.SABEDORIA,modSabedoria, null, false),
                new PericiasVO("Investigação", AtributosEnum.SABEDORIA,modSabedoria, null, false),
                new PericiasVO("Medicina", AtributosEnum.SABEDORIA ,modSabedoria, null, false),
                new PericiasVO("Natureza", AtributosEnum.SABEDORIA,modSabedoria, null, false),
                new PericiasVO("Sobrevivência", AtributosEnum.SABEDORIA,modSabedoria, null, false),

                new PericiasVO("Haki", AtributosEnum.VONTADE,modVontade, null, false),
                new PericiasVO("Intuição", AtributosEnum.VONTADE,modVontade, null, false),
                new PericiasVO("Percepção", AtributosEnum.VONTADE,modVontade, null, false),
                new PericiasVO("Sobrenatural", AtributosEnum.VONTADE,modVontade, null, false),
                new PericiasVO("Sorte", AtributosEnum.VONTADE,modVontade, null, false),

                new PericiasVO("Atuação", AtributosEnum.PRESENCA,modPresenca, null, false),
                new PericiasVO("Enganação", AtributosEnum.PRESENCA,modPresenca, null, false),
                new PericiasVO("Intimidação", AtributosEnum.PRESENCA,modPresenca, null, false),
                new PericiasVO("Persuasão", AtributosEnum.PRESENCA,modPresenca, null, false),
                new PericiasVO("Provocação", AtributosEnum.PRESENCA,modPresenca, null, false),
            };



        }
    }
}
