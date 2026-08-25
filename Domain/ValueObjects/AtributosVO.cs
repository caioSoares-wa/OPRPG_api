using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class AtributosVO
    {
        public int Forca { get; set; } 
        public int Destreza { get; set; } 
        public int Constituicao { get; set; }
        public int Sabedoria { get; set; } 
        public int Presenca { get; set; } 
        public int Vontade { get; set; } 

        public int ForcaMod { get; set; }
        public int DestrezaMod { get; set; }
        public int ConstituicaoMod { get; set; }
        public int SabedoriaMod { get; set; }
        public int PresencaMod { get; set; }
        public int VontadeMod { get; set; }



        public AtributosVO(int forca, int destreza, int constituicao, int sabedoria, int presenca, int vontade) {

            this.Forca = verificarAtributo(forca); 
            this.Destreza = verificarAtributo(destreza); 
            this.Constituicao = verificarAtributo(constituicao); 
            this.Sabedoria = verificarAtributo(sabedoria); 
            this.Presenca = verificarAtributo(presenca); 
            this.Vontade = verificarAtributo(vontade); 


            this.ForcaMod = ((this.Forca) -10) / 2;
            this.DestrezaMod = ((this.Destreza) - 10) / 2;
            this.ConstituicaoMod = ((this.Constituicao) - 10) / 2;
            this.SabedoriaMod = ((this.Sabedoria) - 10) / 2;
            this.PresencaMod = ((this.Presenca) - 10) / 2;
            this.VontadeMod = ((this.Vontade) - 10) / 2;
        }
        
        private int verificarAtributo(int atr)
        {

            if (atr < 0)
            {
                throw new ArgumentException("O valor do atributo não pode ser menor que 0");
            }else if (atr> 30)
            {
                throw new ArgumentException("O valor do atributo não pode ser maior que 30");
            }




            return atr;
        }
    }
}
