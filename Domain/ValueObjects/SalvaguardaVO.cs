using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class SalvaguardaVO 
    {

        public ProficienciaVO ProficienciaVO { get; }  
        public AtributosVO AtributosVO { get; }
        public EstiloDeCombateVO estiloDeCombateVO { get; }

        public int ForcaTot { get; private set; }
        public int DestrezaTot { get; private set; }
        public int ConstituicaoTot { get; private set; }
        public int SabedoriaTot { get; private set; }
        public int PresencaTot { get; private set; }
        public int VontadeTot { get; private set; }


        private Dictionary<AtributosEnum, bool> ehProficiente = new Dictionary<AtributosEnum, bool>
        {
            [AtributosEnum.Forca] = false,
            [AtributosEnum.Destreza] = false,
            [AtributosEnum.Constituicao] = false,
            [AtributosEnum.Sabedoria] = false,
            [AtributosEnum.Presenca] = false,
            [AtributosEnum.Vontade] = false,
        };

        public SalvaguardaVO (AtributosVO atributos, ProficienciaVO proficiencia, EstiloDeCombateVO estiloDeCombate)
        {
            this.AtributosVO = atributos;
            this.ProficienciaVO = proficiencia;
            this.estiloDeCombateVO = estiloDeCombate;

            ImplementarBonusSalvaguarda();
            
           
        }

        private void ImplementarBonusSalvaguarda()
        {
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
            }
        }

        public void MudarAtributo(Dictionary<AtributosEnum, bool> listaDeSalvaguardasEscolhidas)
        {

            var listaDeSalvaguardasPermitidas = estiloDeCombateVO.Salvaguarda;

            foreach (var items in listaDeSalvaguardasEscolhidas)
            {

                if (!listaDeSalvaguardasPermitidas.Contains(items.Key))
                {
                    throw new Exception("Não é possivel selecionar essa salvaguarda");
                }

                this.ehProficiente[items.Key] = true;
            }


            ImplementarBonusSalvaguarda();
        }



    }
}
