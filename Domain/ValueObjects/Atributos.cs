using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    internal class Atributos
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



        public Atributos(int forca, int destreza, int constituicao, int sabedoria, int presenca, int vontade) {
            this.Forca = forca;
            this.Destreza = destreza;
            this.Constituicao = constituicao;
            this.Sabedoria = sabedoria;
            this.Presenca = presenca;
            this.Vontade = vontade;


            this.ForcaMod = (this.Forca) / 2;
            this.DestrezaMod = (this.Destreza) / 2;
            this.ConstituicaoMod = (this.Constituicao) / 2;
            this.SabedoriaMod = (this.Sabedoria) / 2;
            this.PresencaMod = (this.Presenca) / 2;
            this.VontadeMod = (this.Vontade) / 2;
        }
        
        
    }
}
