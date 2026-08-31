using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record PericiasVO
    {

        public PericiasEnum Nome { get; init; }
        public bool EhTreinado { get; init; }
        public int AtributoBase { get; init; }
        public int ValorTotal { get; init; }



        public PericiasVO(PericiasEnum pericia , bool ehTreinado , int atributoBase, int proficiencia)
        {
            this.AtributoBase = atributoBase;
            this.EhTreinado = ehTreinado;


            this.ValorTotal = CalcularValorTotal(atributoBase , proficiencia);
        }



        private int CalcularValorTotal(int atributoBase , int proficiencia)
        {
            int total = atributoBase;

            if (EhTreinado)
            {
                total += proficiencia;
            }

            return total;

        }
    }
}
