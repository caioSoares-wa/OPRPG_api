using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record VariantesVO
    {
        public VariantesEnum Variante { get; init; }
        public string Descricao { get; init; } = string.Empty;
        public string DescricaoBonus { get; init; } = string.Empty;
       


        public VariantesVO( VariantesEnum variante) {
            this.Variante = variante;
            switch  (Variante) {
                case VariantesEnum.Birkans:
                    this.Descricao = "Habitantes de Birka, ilha localizada ao sudeste de Skypiea. Suas asas são as mais distintas, pois suas penas apontam para baixo. Alguns membros possuem uma fisionomia única que lembra bodes. É uma civilização religiosa com foco em cerimônias de ritos";
                    this.DescricaoBonus = "Recebe um bônus de +5 em Testes de Atributo de Presença (Atuação)";
                    break;
                case VariantesEnum.Shadians:
                    this.Descricao = "Antigos habitantes de Jaya no Mar Azul, cuja tribo e metade de sua terra natal foram arremessadas ao céu. Vestem roupas tribais e adornam seus corpos com pinturas e tatuagens. Possuem uma cultura de guerreiros focada no vigor e no treinamento físico intenso";
                    this.DescricaoBonus= "Recebe um bônus de +5 em Testes de Atributo de Força (Atletismo)";
                    break;
                case VariantesEnum.Skypeans:
                    this.Descricao = "O povo mais comum e pacífico dos céus. São conhecidos pela burocracia extrema em suas leis, por usar dials em tarefas rotineiras e pelo cumprimento tradicional \"Heso\" (umbigo). Seus penteados se assemelham a antenas e possuem a pele mais clara do que a dos Shandians";
                    this.DescricaoBonus = "Benefício (Diplomata Celestial): Recebe um bônus de +5 em Testes de Atributo de Presença (Persuasão)";
                    break;
                case VariantesEnum.HumanosComuns:
                    this.Descricao = "A variante humana mais versátil, comum, imprevisível e espalhada por todas as partes do planeta";
                    this.DescricaoBonus = "O jogador escolhe uma perícia na qual já seja proficiente e dobra o Bônus de Proficiência nessa perícia";
                    break;
                case VariantesEnum.Humanozarroes:
                    this.Descricao = "Humanos nascidos com uma estatura gigante e incomum que atinge proporções colossais (muitas vezes ultrapassando os 8 metros de altura";
                    this.DescricaoBonus = "A categoria de tamanho do personagem aumenta para Grande e ele recebe um bônus de +2 em Salvaguardas de Força";
                    break;
                case VariantesEnum.TriboBraçoLongo:
                    this.Descricao = "Humanos caracterizados por possuírem duas articulações de ombros nos membros superiores (dois cotovelos em cada braço), conferindo alcance alongado. Tradicionalmente vestem-se com o clássico manto Changpao decorado com caracteres kanji. Possuem uma rivalidade sangrenta histórica de mais de mil anos com a Tribo Pernas Longas";
                    this.DescricaoBonus = "Recebe alcance de 3 metros em jogadas de ataque (comum) corpo a corpo feitas com os braços e ganha um bônus de +2 em Testes de Atributo de Destreza (Prestidigitação)";
                    break;
                case VariantesEnum.TriboKujas:
                    this.Descricao = "Tribo de mulheres nascidas na ilha isolacionista de Amazon Lily. Criadas como guerreiras, herdam uma forte aversão a homens e usam nomes de flores";
                    this.DescricaoBonus = "O personagem começa o jogo com uma cobra de estimação totalmente obediente. Ela atua no mesmo turno em combate e utiliza as estatísticas da ficha oficial da Cobra Bélica";
                    break;
                case VariantesEnum.TriboPernasLongas:
                    this.Descricao = "Humanos dotados de pernas extremamente alongadas e de musculatura muito desenvolvida. Por tradição, vestem-se deixando suas pernas inteiramente expostas e decoram suas coxas com tatuagens. Vivem em guerra declarada contra a Tribo Braços Longos";
                    this.DescricaoBonus = "Recebe alcance de 3 metros em jogadas de ataque (comum) corpo a corpo com as pernas e seu deslocamento normal terrestre é aumentado para 12 metros";
                    break;
                case VariantesEnum.TriboPescocoDeCobra:
                    this.Descricao = "Caracterizam-se por pescoços extremamente finos e longos, que podem alcançar até 1 metro de comprimento, assemelhando-se visualmente a serpentes";
                    this.DescricaoBonus = "Recebe alcance de 3 metros em jogadas de ataque (comum) corpo a corpo ao usar a cabeça para atacar e ganha um bônus de +2 em Testes de Atributo de Vontade (Percepção) que dependam da visão";
                    break;
                case VariantesEnum.TriboDosTresOlhos:
                    this.Descricao = "Humanos raros que possuem um terceiro olho místico posicionado no centro da testa. Diz-se que o despertar completo deste olho permite habilidades divinas";
                    this.DescricaoBonus = "Concede proficiência em Testes de Atributo de Vontade em uma perícia à sua escolha entre: Haki, Sobrenatural ou Sorte";
                    break;
                case VariantesEnum.Ageis:
                    this.Descricao = "Minks pequenos, esguios e muito leves. São batedores naturais por serem extremamente difíceis de detectar";
                    this.DescricaoBonus = "O deslocamento terrestre básico aumenta para 12 metros e o personagem recebe um deslocamento de escalada de 9 metros";
                    break;
                case VariantesEnum.Meaos:
                    this.Descricao = "Minks de estatura média e proporções equilibradas semelhantes às humanas. Conseguem dosar perfeitamente agilidade e força bruta";
                    this.DescricaoBonus = "O deslocamento terrestre básico do personagem aumenta para 18 metros";
                    break;
                case VariantesEnum.Robustos:
                    this.Descricao = "Minks imponentes de constituição pesada, altos, largos e extremamente resistentes";
                    this.DescricaoBonus = "O deslocamento terrestre básico aumenta para 12 metros e o personagem torna-se imune a reduções de deslocamento causadas por terreno difícil";
                    break;
                case VariantesEnum.HomemPeixe:
                    this.Descricao = "Humanoides que unem a estrutura corporal terrestre com traços nítidos de animais marinhos, como tentáculos, guelras e barbatanas";
                    this.DescricaoBonus = "O tritão pode escolher 1 Traço Comum de Akuma no Mi Zoan. Este traço deve obrigatoriamente condizer com a espécie do seu animal marinho ancestral (ignorando exigências de forma Zoan)";
                    break;
                case VariantesEnum.Sireno:
                    this.Descricao = "Possuem a porção superior do corpo idêntica à humana, enquanto a porção inferior (da cintura para baixo) é composta por uma cauda de peixe. Possuem uma beleza fascinante reconhecida em todo o mundo";
                    this.DescricaoBonus = "Recebe 18 metros de deslocamento de nado e pode usar a ação de Disparada como uma Ação Bônus enquanto estiver na água";
                    break;
               
            }


        }
     

     

    }
}
