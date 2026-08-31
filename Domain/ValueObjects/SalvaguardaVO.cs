using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record SalvaguardaVO 
    {

        public ProficienciaVO ProficienciaVO { get; }  
        public AtributosVO AtributosVO { get; }
        public EstiloDeCombateVO estiloDeCombateVO { get; }

        public int ForcaTot { get; init; }
        public int DestrezaTot { get; init; }
        public int ConstituicaoTot { get; init; }
        public int SabedoriaTot { get; init; }
        public int PresencaTot { get; init; }
        public int VontadeTot { get; init; }

        public List<AtributosEnum> SalvaguardasEscolhidas { get; private set; }


        private Dictionary<AtributosEnum, bool> ehProficiente = new Dictionary<AtributosEnum, bool>
        {
            [AtributosEnum.Forca] = false,
            [AtributosEnum.Destreza] = false,
            [AtributosEnum.Constituicao] = false,
            [AtributosEnum.Sabedoria] = false,
            [AtributosEnum.Presenca] = false,
            [AtributosEnum.Vontade] = false,
        };

        public SalvaguardaVO (AtributosVO atributos, ProficienciaVO proficiencia, EstiloDeCombateVO estiloDeCombate, List<AtributosEnum> salvaguardasEscolhidas)
        {
            this.AtributosVO = atributos;
            this.ProficienciaVO = proficiencia;
            this.estiloDeCombateVO = estiloDeCombate;
            this.SalvaguardasEscolhidas = salvaguardasEscolhidas;
            ImplementarBonusSalvaguarda();
            
           
        }

        private void ImplementarBonusSalvaguarda(){
            foreach (var i in SalvaguardasEscolhidas)
            {
                if (!estiloDeCombateVO.Salvaguarda.Contains(i))
                {
                    throw new Exception($"Salvaguarda {i}, Não pode ser escolhida pelo estilo de combate {estiloDeCombateVO.Estilo}");


                }
                this.ehProficiente[i] = true;
            }

            foreach (var item in ehProficiente )
            {

                if (item.Value)
                {
                    switch (item.Key)
                    {
                        case AtributosEnum.Forca:
                            this.ForcaTot = ProficienciaVO.Proficiencia + AtributosVO.ForcaMod;
                            break;
                        case AtributosEnum.Destreza:
                            this.DestrezaTot = ProficienciaVO.Proficiencia + AtributosVO.DestrezaMod;
                            break;
                        case AtributosEnum.Constituicao:
                            this.ConstituicaoTot = ProficienciaVO.Proficiencia + AtributosVO.ConstituicaoMod;
                            break;
                        case AtributosEnum.Sabedoria:
                            this.SabedoriaTot = ProficienciaVO.Proficiencia + AtributosVO.SabedoriaMod;
                            break;
                        case AtributosEnum.Presenca:
                            this.PresencaTot = ProficienciaVO.Proficiencia + AtributosVO.PresencaMod;
                            break;
                        case AtributosEnum.Vontade:
                            this.VontadeTot = ProficienciaVO.Proficiencia + AtributosVO.VontadeMod;
                            break;
                    }
                }
                else
                {
                    switch (item.Key)
                    {
                        case AtributosEnum.Forca:
                            this.ForcaTot = AtributosVO.ForcaMod;
                            break;
                        case AtributosEnum.Destreza:
                            this.DestrezaTot = AtributosVO.DestrezaMod;
                            break;
                        case AtributosEnum.Constituicao:
                            this.ConstituicaoTot = AtributosVO.ConstituicaoMod;
                            break;
                        case AtributosEnum.Sabedoria:
                            this.SabedoriaTot = AtributosVO.SabedoriaMod;
                            break;
                        case AtributosEnum.Presenca:
                            this.PresencaTot = AtributosVO.PresencaMod;
                            break;
                        case AtributosEnum.Vontade:
                            this.VontadeTot = AtributosVO.VontadeMod;
                            break;
                    }

                }

            }
        }




    }
}
