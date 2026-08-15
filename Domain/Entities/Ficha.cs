using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    class Ficha
    {
        public string NomePersonagem { get; set; } = string.Empty;
        public int Nivel { get; set; }
        public int Proficiencia { get; set; }
        public Especies Especie { get; set; }
        public Antecedentes Antecedentes { get; set; }
        public AkumaNoMi AkumaNoMi { get; set; }
        public Profissoes Profissoes { get; set; }
        public Deslocamento Deslocamento { get; set; }
        public int Vida { get; set; }
        public ClasseDeResistencia ClasseDeResistencia { get; set; }
        public ClasseDeDificuldade ClasseDeDificuldade { get; set; }

        public int PontosDePoder { get; set; }


        public Atributos Atributos { get; set; }
        public Pericias Pericias { get; set; }
        


        private Ficha()
        {



            Atributos = CalcularAtributos();
            Pericias = CalcularPericias();
            CalcularVida();
            CalcularClasseDeDificuldade();
            CalcularClasseDeResistencia();



        }

        private Pericias CalcularPericias()
        {

            return new Pericias();
        }

        private Atributos CalcularAtributos()
        {

            return new Atributos();
        }

        private int CalcularVida()
        {
            return 0;
        }

        private int CalcularClasseDeResistencia()
        {
            return 0;
        }
        private int CalcularClasseDeDificuldade()
        {
            return 0;
        }


    }
}
