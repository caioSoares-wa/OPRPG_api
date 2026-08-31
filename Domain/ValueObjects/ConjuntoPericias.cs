using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record ConjuntoPericias
    {
       

        public Dictionary<PericiasEnum, PericiasVO> TodasAsPericias {  get; init; }
        public IEnumerable<PericiasEnum> PericiasSelecionadas { get; init; }
        public EstiloDeCombateVO Estilo { get; }
        public ProfissoesVO Profissoes { get; }
        public AtributosVO Atributos { get; }
        public ProficienciaVO Proficiencia { get; }


        public ConjuntoPericias(ProfissoesVO profissao, EstiloDeCombateVO estilo,ProficienciaVO proficiencia,AtributosVO atributos) {
            this.Estilo = estilo;
            this.Profissoes = profissao;
            this.Proficiencia = proficiencia;
            this.Atributos = atributos;



            this.PericiasSelecionadas = Estilo.PericiasSelecionadas.Concat(Profissoes.PericasEscolhidas).Distinct();

            DefinirPericias();
            
        }


        private void DefinirPericias() {
            TodasAsPericias = new();

            List<PericiasEnum> baseadoemForca = new List<PericiasEnum>() {PericiasEnum.Atletismo };
            List<PericiasEnum> baseadoemDestreza = new List<PericiasEnum>() { PericiasEnum.Acrobacia,PericiasEnum.Furtividade,PericiasEnum.Prestidigitacao };
            List<PericiasEnum> baseadoemSabedoria = new List<PericiasEnum>() { PericiasEnum.Historia,PericiasEnum.Investigacao,PericiasEnum.Natureza , PericiasEnum.Sobrevivencia };
            List<PericiasEnum> baseadoemPresenca = new List<PericiasEnum>() { PericiasEnum.Atuacao,PericiasEnum.Enganacao,PericiasEnum.Intimidacao,PericiasEnum.Persuasao,PericiasEnum.Provocacao };
            List<PericiasEnum> baseadoemVontade = new List<PericiasEnum>() { PericiasEnum.Haki,PericiasEnum.Intuicao,PericiasEnum.Percepcao,PericiasEnum.Sobrenatural,PericiasEnum.Sorte };

            foreach (var perks in Enum.GetValues<PericiasEnum>() )
            {
                bool treinado = false;
                int atributoBase = 0;


                if (PericiasSelecionadas.Contains(perks))
                {
                    treinado = true;
                }


                if (baseadoemForca.Contains(perks))
                {
                    atributoBase = Atributos.ForcaMod;
                }else if (baseadoemDestreza.Contains(perks))
                {
                    atributoBase = Atributos.DestrezaMod;
                }else if (baseadoemSabedoria.Contains(perks))
                {
                    atributoBase = Atributos.SabedoriaMod;
                }else if (baseadoemPresenca.Contains(perks))
                {
                    atributoBase = Atributos.PresencaMod;
                }
                else if(baseadoemVontade.Contains(perks))
                {
                    atributoBase = Atributos.VontadeMod;
                }
                



                TodasAsPericias.Add(perks,new PericiasVO(perks,treinado,atributoBase,Proficiencia.Proficiencia));

            }
            
        }
    }
}
