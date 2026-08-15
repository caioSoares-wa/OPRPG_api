using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class EstiloDeCombate
    {
         public int DadosDeVida { get; private set; }

        public EstilosEnum Estilo { get; private set; }

        public List<AtributosEnum> AtributoPrimario { get; private set; }

        public List<AtributosEnum> Salvaguarda { get; private set; }

        public string ProficienciaEmArmas { get; private set; } = string.Empty;

        public List<PericiasEnum> PericiasSelecionadas { get; private set; } = new List<PericiasEnum>();

        public string ArmaFavorita { get; private set; } = string.Empty;


        public EstiloDeCombate(List<PericiasEnum> pericias, EstilosEnum estilo)
        {
            PericiasSelecionadas = ConfigurarAtributosDoEstilo(pericias, estilo);
            this.Estilo = estilo;
        }

        private static readonly Dictionary<EstilosEnum, (List<PericiasEnum> opçoes, int quantidade)> PericiasPorEstilo = new() {

            [EstilosEnum.Atirador] = (
              new List<PericiasEnum> { PericiasEnum.Atletismo, PericiasEnum.Acrobacia, PericiasEnum.Furtividade, PericiasEnum.Prestidigitacao, PericiasEnum.Historia, PericiasEnum.Investigacao, PericiasEnum.Natureza, PericiasEnum.Sobrevivencia, PericiasEnum.Atuacao, PericiasEnum.Enganacao, PericiasEnum.Intimidacao, PericiasEnum.Persuasao, PericiasEnum.Provocacao, PericiasEnum.Haki, PericiasEnum.Intuicao, PericiasEnum.Percepcao, PericiasEnum.Sobrenatural, PericiasEnum.Sorte },
                3),

            [EstilosEnum.Aventureiro] = (
                new List<PericiasEnum> { PericiasEnum.Atletismo, PericiasEnum.Acrobacia, PericiasEnum.Furtividade, PericiasEnum.Prestidigitacao, PericiasEnum.Historia, PericiasEnum.Investigacao, PericiasEnum.Natureza, PericiasEnum.Sobrevivencia, PericiasEnum.Atuacao, PericiasEnum.Enganacao, PericiasEnum.Intimidacao, PericiasEnum.Persuasao, PericiasEnum.Provocacao, PericiasEnum.Haki, PericiasEnum.Intuicao, PericiasEnum.Percepcao, PericiasEnum.Sobrenatural, PericiasEnum.Sorte }, 3
            ),
            [EstilosEnum.Brutamontes] = (
                new List<PericiasEnum> { PericiasEnum.Atletismo, PericiasEnum.Intimidacao, PericiasEnum.Provocacao, PericiasEnum.Sobrevivencia }, 2
            ),
            [EstilosEnum.CaratecaHomemPeixe] = (
                new List<PericiasEnum> { PericiasEnum.Acrobacia, PericiasEnum.Atletismo, PericiasEnum.Atuacao, PericiasEnum.Intimidacao }, 2
            ),
            [EstilosEnum.Ciborgue] = (
                new List<PericiasEnum> { PericiasEnum.Atletismo, PericiasEnum.Investigacao, PericiasEnum.Prestidigitacao, PericiasEnum.Sobrevivencia }, 2
            ),
            [EstilosEnum.Espadachim] = (
                new List<PericiasEnum> { PericiasEnum.Atletismo, PericiasEnum.Intimidacao, PericiasEnum.Intuicao, PericiasEnum.Percepcao }, 2
            ),
            [EstilosEnum.Guerrilheiro] = (
                new List<PericiasEnum> { PericiasEnum.Acrobacia,PericiasEnum.Atletismo,PericiasEnum.Furtividade,PericiasEnum.Historia,PericiasEnum.Sobrevivencia },2
            
            ),
            [EstilosEnum.Lutador] = (
                new List<PericiasEnum> {PericiasEnum.Atletismo,PericiasEnum.Intimidacao,PericiasEnum.Provocacao,PericiasEnum.Sobrevivencia }, 2

            ),
            [EstilosEnum.Ninja] = (
                new List<PericiasEnum> {PericiasEnum.Acrobacia,PericiasEnum.Enganacao,PericiasEnum.Furtividade,PericiasEnum.Prestidigitacao }, 2
            ),
            [EstilosEnum.OkamaKenpo] = (
                new List<PericiasEnum> { PericiasEnum.Acrobacia,PericiasEnum.Atletismo,PericiasEnum.Atuacao,PericiasEnum.Enganacao,PericiasEnum.Intimidacao,PericiasEnum.Intuicao,PericiasEnum.Provocacao}, 3

            ),
            [EstilosEnum.Rokushiki] = (
                new List<PericiasEnum> { PericiasEnum.Acrobacia,PericiasEnum.Enganacao,PericiasEnum.Furtividade,PericiasEnum.Historia,PericiasEnum.Investigacao}, 2

            ),
            [EstilosEnum.Samurai] = (
                new List<PericiasEnum> {PericiasEnum.Intimidacao,PericiasEnum.Intuicao,PericiasEnum.Percepcao,PericiasEnum.Sobrevivencia }, 2

            ),

        };
            
       



        public List<PericiasEnum> ConfigurarAtributosDoEstilo(List<PericiasEnum> pericias, EstilosEnum estilo)
        {

            

            switch (estilo) {
                case EstilosEnum.Atirador:
                    
                    if (pericias.Count != 3)
                    {
                        throw new ArgumentException("O estilo de combate Atirador requer 3 perícias selecionadas.");
                    }

                    this.DadosDeVida = 8;
                    this.AtributoPrimario = new List<AtributosEnum> { AtributosEnum.Destreza };     
                    this.Salvaguarda = new List<AtributosEnum> { AtributosEnum.Destreza, AtributosEnum.Sabedoria };
                    this.ProficienciaEmArmas = "Armas de Fogo, Lançador de Arpão, Bazuca, Canhão e Armas de Navio";
                    this.PericiasSelecionadas = pericias;
                    break;

                case EstilosEnum.Aventureiro:

                    if (pericias.Count != 3)
                    {
                        throw new ArgumentException("O Estilo de combate Aventureiro requer 3 perícias selecionadas.");
                    }

                    this.DadosDeVida = 10;
                    this.AtributoPrimario = new List<AtributosEnum> { AtributosEnum.Destreza };
                    this.Salvaguarda = new List<AtributosEnum> {AtributosEnum.Destreza, AtributosEnum.Constituicao };
                    this.ProficienciaEmArmas = "Armas Cortantes, Armas de Fogo, Armas Especiais e Armas Marciais";
                    this.PericiasSelecionadas = VerificarPericias(pericias);
                    break;

                case EstilosEnum.Brutamontes:

                    if (pericias.Count != 2)
                    {
                        throw new ArgumentException("O Estilo de combate Brutamontes requer 2 perícias selecionadas.");
                    }

                    this.DadosDeVida = 12;
                    this.AtributoPrimario = new List<AtributosEnum> { AtributosEnum.Forca };
                    this.Salvaguarda = new List<AtributosEnum> { AtributosEnum.Forca, AtributosEnum.Constituicao };
                    this.ProficienciaEmArmas = "Kanabo (e Tacape)";
                    this.PericiasSelecionadas = VerificarPericias(pericias);

                    break;
                case EstilosEnum.CaratecaHomemPeixe:

                    break;
                case EstilosEnum.Ciborgue:

                    break;
                case EstilosEnum.Espadachim:

                    break;
                case EstilosEnum.Guerrilheiro: 

                    break;
                case EstilosEnum.Lutador: 

                    break;
                case EstilosEnum.Ninja: 

                    break;
                case EstilosEnum.OkamaKenpo: 

                    break;
                case EstilosEnum.Rokushiki:

                    break;
                case EstilosEnum.Samurai: 

                    break;





            }



           return pericias;
        }


         private List<PericiasEnum> VerificarPericias(List<PericiasEnum> pericias )
        {

            List <PericiasEnum> periciasVerificadas = new List<PericiasEnum>();

            foreach (var pericia in PericiasPorEstilo )
            {

                

            }


            return periciasVerificadas;
        }
    }
}
