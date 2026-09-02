using Domain.Enums;
using Domain.ValueObjects.AtributosVOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.PericiasVOs
{
    public record PericiasVO
    {
        public string Nome { get; init; }
        public AtributosEnum AtributoUtilizado { get; init; }
        public int ModificadorAtributo { get; init; }
        public int Total { get; init; }
        public int? OutrosBonus {get; init; }
        public bool EhProficiente { get; init; }


        public PericiasVO(string nomePericia , AtributosEnum atributoUtilizado,int modificadorDoAtributo, int? outrosBonus,bool proficiente )
        {
            this.Nome = nomePericia;
            this.AtributoUtilizado = atributoUtilizado;
            this.OutrosBonus = outrosBonus;
            this.EhProficiente = proficiente;
            this.ModificadorAtributo = modificadorDoAtributo;


            Total = CalcularTotal() ;
           
        }


        public PericiasVO AlterarProficiencia()
        {

            string nome = this.Nome;
            AtributosEnum atributo = this.AtributoUtilizado;
            int? bonus = this.OutrosBonus;
            int modificador = this.ModificadorAtributo;






            return new PericiasVO(nome, atributo,modificador, bonus, true);
        }


        private int CalcularTotal(int bonusProficiencia)
        {


            return ModificadorAtributo + proficiencia + outros;
        }


    }
}
