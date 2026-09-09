using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.AtributosVOs
{
    public record AtributoVO
    {
        public AtributosEnum Nome { get; init; } 
        public int ValorBase { get; init; } 
        public int Modificador { get; init; }


        public AtributoVO(AtributosEnum nomeAtributo,int valorDoAtributo)
        {
            this.Nome = nomeAtributo;


            this.ValorBase = VerificarValor(valorDoAtributo);

            this.Modificador = (int)Math.Floor((this.ValorBase - 10) / 2.0);



        }


        private static int VerificarValor(int valor)
        {
            if (valor <= 0)
            {
                valor = 0;
            }
            else if (valor > 30) {
                valor =  30;
            }

            return valor;
        }




    }

}
