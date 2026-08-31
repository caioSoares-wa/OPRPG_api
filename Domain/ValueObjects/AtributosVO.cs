using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record AtributosVO
    {
        public int Forca { get; init; } 
        public int Destreza { get; init; } 
        public int Constituicao { get; init; }
        public int Sabedoria { get; init; } 
        public int Presenca { get; init; } 
        public int Vontade { get; init; } 

        public int ForcaMod { get; init; }
        public int DestrezaMod { get; init; }
        public int ConstituicaoMod { get; init; }
        public int SabedoriaMod { get; init; }
        public int PresencaMod { get; init; }
        public int VontadeMod { get; init; }



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
