using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public class PericiasVO
    {

        public PericiasEnum Nome { get; private set; }
        public bool EhTreinado { get; private set; }
        public int AtributoBase { get; private set; }
        public int ValorTotal { get; private set; }


        public PericiasVO(PericiasEnum nome,PericiasEnum pericia , bool ehTreinado , int atributoBase, int proficiencia)
        {
            this.AtributoBase = atributoBase;
            this.Nome = nome;
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
