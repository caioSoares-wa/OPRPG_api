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

        public AtributosEnum AtributoPrimario { get; private set; }

        public List<AtributosEnum> Salvaguarda { get; private set; }

        public string ProficienciaEmArmas { get; private set; } = string.Empty;

        public List<PericiasEnum> PericiasSelecionadas { get; private set; } = new List<PericiasEnum>();

        public string ArmaFavorita { get; private set; } = string.Empty;


        public EstiloDeCombate(List<PericiasEnum> pericias, EstilosEnum estilo , AtributosEnum atributoPrimario) 
        {
            this.Estilo = estilo;
            this.PericiasSelecionadas = VerificarPericias(pericias);
            this.DadosDeVida = ImplementarDadosDeVida();
            this.Salvaguarda = ImplementarSalvaguarda();
            this.AtributoPrimario = DefinirAtributoPrimario(atributoPrimario);
            this.ProficienciaEmArmas = ImplementarProficienciaEmArmas();
            this.ArmaFavorita = ImplementarArmaFavorita();

        }

        private static readonly Dictionary<EstilosEnum, (List<PericiasEnum> opçoes, int quantidade)> PericiasPorEstilo = new(){

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
                new List<PericiasEnum> { PericiasEnum.Acrobacia, PericiasEnum.Atletismo, PericiasEnum.Furtividade, PericiasEnum.Historia, PericiasEnum.Sobrevivencia }, 2

            ),
            [EstilosEnum.Lutador] = (
                new List<PericiasEnum> { PericiasEnum.Atletismo, PericiasEnum.Intimidacao, PericiasEnum.Provocacao, PericiasEnum.Sobrevivencia }, 2

            ),
            [EstilosEnum.Ninja] = (
                new List<PericiasEnum> { PericiasEnum.Acrobacia, PericiasEnum.Enganacao, PericiasEnum.Furtividade, PericiasEnum.Prestidigitacao }, 2
            ),
            [EstilosEnum.OkamaKenpo] = (
                new List<PericiasEnum> { PericiasEnum.Acrobacia, PericiasEnum.Atletismo, PericiasEnum.Atuacao, PericiasEnum.Enganacao, PericiasEnum.Intimidacao, PericiasEnum.Intuicao, PericiasEnum.Provocacao }, 3

            ),
            [EstilosEnum.Rokushiki] = (
                new List<PericiasEnum> { PericiasEnum.Acrobacia, PericiasEnum.Enganacao, PericiasEnum.Furtividade, PericiasEnum.Historia, PericiasEnum.Investigacao }, 2

            ),
            [EstilosEnum.Samurai] = (
                new List<PericiasEnum> { PericiasEnum.Intimidacao, PericiasEnum.Intuicao, PericiasEnum.Percepcao, PericiasEnum.Sobrevivencia }, 2

            ),

        };
  

        private List<PericiasEnum> VerificarPericias(List<PericiasEnum> pericias)
        {

            List<PericiasEnum> periciasVerificadas = new List<PericiasEnum>();

            int quantidadeSelecionada = pericias.Count;
            int quantidadePermitida = 0;

            foreach (var lista in PericiasPorEstilo)
            {
                if (Estilo == lista.Key)
                {
                    periciasVerificadas = lista.Value.opçoes;
                    quantidadePermitida = lista.Value.quantidade;
                }
            }

            if (quantidadeSelecionada != quantidadePermitida)
            {
                throw new ArgumentException($"O estilo de combate {this.Estilo} só pode ter {quantidadePermitida} perícias.");
            }


            List<PericiasEnum> periciasCertas = new List<PericiasEnum>(); 

            foreach (var itens in pericias)
            {
                if (periciasVerificadas.Contains(itens))
                {

                    if (!periciasCertas.Contains(itens))
                    {
                        periciasCertas.Add(itens);
                    }
                    else
                    {
                        throw new Exception($"A Pericia {itens}, já foi escolhida!");
                    }

                }
                else
                {
                    throw new ArgumentException($"A pericia {itens}, não pode ser selecionada para o estilo {Estilo}");
                }
                ;

            }



            return periciasCertas;
        }

        private int ImplementarDadosDeVida()
        {
            switch (Estilo)
            {
                case EstilosEnum.Atirador:
                    return 8;
                case EstilosEnum.Aventureiro:
                    return 10;
                case EstilosEnum.Brutamontes:
                    return 12;
                case EstilosEnum.CaratecaHomemPeixe:
                    return 12;
                case EstilosEnum.Ciborgue:
                    return 12;
                case EstilosEnum.Espadachim:
                    return 10;
                case EstilosEnum.Guerrilheiro:
                    return 10;
                case EstilosEnum.Lutador:
                    return 12;
                case EstilosEnum.Ninja:
                    return 8;
                case EstilosEnum.OkamaKenpo:
                    return 10;
                case EstilosEnum.Rokushiki:
                    return 10;
                case EstilosEnum.Samurai:
                    return 10;
            }
            return 0;
        }

        private List<AtributosEnum> ImplementarSalvaguarda()
        {
            switch (Estilo)
            {
                case EstilosEnum.Atirador:
                    return new List<AtributosEnum>() {AtributosEnum.Destreza , AtributosEnum.Sabedoria} ;
                case EstilosEnum.Aventureiro:
                    return new List<AtributosEnum>() {AtributosEnum.Destreza , AtributosEnum.Constituicao };
                case EstilosEnum.Brutamontes:
                    return new List<AtributosEnum>() {AtributosEnum.Forca, AtributosEnum.Constituicao };
                case EstilosEnum.CaratecaHomemPeixe:
                    return new List<AtributosEnum>() { AtributosEnum.Forca, AtributosEnum.Constituicao};
                case EstilosEnum.Ciborgue:
                    return new List<AtributosEnum>() {AtributosEnum.Forca , AtributosEnum.Sabedoria };
                case EstilosEnum.Espadachim:
                    return new List<AtributosEnum>() { AtributosEnum.Destreza , AtributosEnum.Vontade } ;
                case EstilosEnum.Guerrilheiro:
                    return new List<AtributosEnum>() { AtributosEnum.Forca, AtributosEnum.Destreza} ;
                case EstilosEnum.Lutador:
                    return new List<AtributosEnum>() { AtributosEnum.Forca, AtributosEnum.Constituicao} ;
                case EstilosEnum.Ninja:
                    return new List<AtributosEnum>(){AtributosEnum.Destreza, AtributosEnum.Sabedoria };
                case EstilosEnum.OkamaKenpo:
                    return new List<AtributosEnum>() {AtributosEnum.Destreza, AtributosEnum.Presenca };
                case EstilosEnum.Rokushiki:
                    return new List<AtributosEnum>() { AtributosEnum.Forca, AtributosEnum.Destreza};
                case EstilosEnum.Samurai:
                    return new List<AtributosEnum>() { AtributosEnum.Constituicao, AtributosEnum.Vontade};
            }

           return new List<AtributosEnum>() { };
        }

        private AtributosEnum DefinirAtributoPrimario(AtributosEnum atributoEscolhido)
        {
            switch (Estilo)
            {
                case EstilosEnum.Atirador:
                    
                    if (atributoEscolhido != AtributosEnum.Destreza)
                    {
                        return AtributosEnum.Destreza;
                    }
                    break;
                case EstilosEnum.Aventureiro:
                    if (atributoEscolhido != AtributosEnum.Destreza)
                    {
                        return AtributosEnum.Destreza;
                    }

                    break;
                case EstilosEnum.Brutamontes:
                    if (atributoEscolhido != AtributosEnum.Forca)
                    {
                        return AtributosEnum.Forca;
                    }
                    break;
                    
                case EstilosEnum.CaratecaHomemPeixe:
                    if (atributoEscolhido != AtributosEnum.Forca)
                    {
                        return AtributosEnum.Forca;
                    }
                    break;
                case EstilosEnum.Ciborgue:
                    List<AtributosEnum> atributoPrimarioPermitidoCiborgue = new List<AtributosEnum>() { AtributosEnum.Sabedoria,AtributosEnum.Forca};

                    if (!atributoPrimarioPermitidoCiborgue.Contains(atributoEscolhido))
                    {
                        throw new Exception($"O Atributo primário escolhido: {atributoEscolhido}, é inválido! ");
                    }

                    break;
                case EstilosEnum.Espadachim:
                    List<AtributosEnum> atributoPrimarioPermitidoEspadachim = new List<AtributosEnum>() { AtributosEnum.Destreza, AtributosEnum.Forca };

                    if (!atributoPrimarioPermitidoEspadachim.Contains(atributoEscolhido))
                    {
                        throw new Exception($"O Atributo primário escolhido: {atributoEscolhido}, é inválido! ");
                    }

                    break;
                case EstilosEnum.Guerrilheiro:
                    List<AtributosEnum> atributoPrimarioPermitidoGuerrilheiro = new List<AtributosEnum>() { AtributosEnum.Destreza, AtributosEnum.Forca };

                    if (!atributoPrimarioPermitidoGuerrilheiro.Contains(atributoEscolhido))
                    {
                        throw new Exception($"O Atributo primário escolhido: {atributoEscolhido}, é inválido! ");
                    }
                    break;
                case EstilosEnum.Lutador:
                    if (atributoEscolhido != AtributosEnum.Forca)
                    {
                        return AtributosEnum.Forca;
                    }
                    break;
                    
                case EstilosEnum.Ninja:
                    if (atributoEscolhido != AtributosEnum.Forca)
                    {
                        return AtributosEnum.Forca;
                    }
                    break;
                case EstilosEnum.OkamaKenpo:
                    List<AtributosEnum> atributoPrimarioPermitidoOkamaKenpo = new List<AtributosEnum>() {AtributosEnum.Forca, AtributosEnum.Presenca};

                    if (!atributoPrimarioPermitidoOkamaKenpo.Contains(atributoEscolhido))
                    {
                        throw new Exception($"O Atributo primário escolhido: {atributoEscolhido} , é inválido!");
                    }
                    break;
                case EstilosEnum.Rokushiki:
                    List<AtributosEnum> atributoPrimarioPermitidoRokushiki = new List<AtributosEnum>() { AtributosEnum.Forca, AtributosEnum.Destreza };

                    if (!atributoPrimarioPermitidoRokushiki.Contains(atributoEscolhido))
                    {
                        throw new Exception($"O Atributo primário escolhido: {atributoEscolhido}, é inválido! ");
                    }
                    break;
                case EstilosEnum.Samurai:
                    List<AtributosEnum> atributoPrimarioPermitidoSamurai = new List<AtributosEnum>() {AtributosEnum.Forca, AtributosEnum.Destreza };

                    if (!atributoPrimarioPermitidoSamurai.Contains(atributoEscolhido))
                    {
                        throw new Exception($"O Atributo primário escolhido: {atributoEscolhido}, é invalido!");
                    }
                    break; 
            }
            return atributoEscolhido;
        }

        private string ImplementarProficienciaEmArmas()
        {
            switch (Estilo) {
                case EstilosEnum.Atirador:
                    return "Armas de Fogo, Lançador de Arpão, Bazuca, Canhão e Armas de Navio";
                case EstilosEnum.Aventureiro:
                    return "Armas Cortantes, Armas de Fogo, Armas Especiais e Armas Marciais";
                case EstilosEnum.Brutamontes:
                    return "Kanabo (e Tacape)";
                case EstilosEnum.CaratecaHomemPeixe:
                    return "Armas Marciais e Tridente";
                case EstilosEnum.Ciborgue:
                    return "Nenhuma";
                case EstilosEnum.Espadachim:
                    return "Armas Cortantes";
                case EstilosEnum.Guerrilheiro:
                    return "Armas Cortantes, Armas de Fogo, Armas Especiais e Armas Marciais";
                case EstilosEnum.Lutador:
                    return "Armas Marciais";
                case EstilosEnum.Ninja:
                    return "Katana, Kunai, Adaga, Shuriken, Foice e Arco";
                case EstilosEnum.OkamaKenpo:
                    return "Armas Marciais";
                case EstilosEnum.Rokushiki:
                    return "Armas Marciais";
                case EstilosEnum.Samurai:
                    return "Armas Cortantes";
            }


            return ProficienciaEmArmas;
        }

        private string ImplementarArmaFavorita()
        {

            switch (Estilo)
            {
                case EstilosEnum.Atirador:
                    return "Escolha entre pistola ou mosquete";
                case EstilosEnum.Aventureiro:
                    return "Escolha entre Chicote, Pistola ou Corporal";
                case EstilosEnum.Brutamontes:
                    return "Escolha entre kanabo, machado grande, martelo de guerra, espada montante ou Corporal";
                case EstilosEnum.CaratecaHomemPeixe:
                    return "Suas proficiências padrão são Armas Marciais e Tridente. No sistema, o tridente é considerado uma arma marcial para eles, e o estilo é altamente focado em combate desarmado. Portanto, suas opções são o Tridente ou “Corporal”";
                case EstilosEnum.Ciborgue:
                    return "Escolha uma entre bazuca, canhão, escopeta ou metralhadora";
                case EstilosEnum.Espadachim:
                    return "Escolha uma arma dentre as Armas Cortantes";
                case EstilosEnum.Guerrilheiro:
                    return "Escolha uma dentre todas as armas possíveis ou “Corporal”";
                case EstilosEnum.Lutador:
                    return "Escolha uma dentre as Armas Marciais ou “Corporal”";
                case EstilosEnum.Ninja:
                    return "Escolha uma entre katana, kunai, adaga, shuriken, foice ou arco";
                case EstilosEnum.OkamaKenpo:
                    return "Escolha uma dentre as Armas Marciais ou “Corporal”";
                case EstilosEnum.Rokushiki:
                    return "Escolha uma entre adaga, katana, bastão ou “Corporal”";
                case EstilosEnum.Samurai:
                    return "Escolha uma dentre arco, daito katana, foice, kanabo, katana, lança, nodachi, pistola e shikomizue";
            }


            return ArmaFavorita;
            
        }

    }
}
