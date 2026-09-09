using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.AtributosVOs
{
    public record ConjuntoAtributosVO
    {
        public List<AtributoVO> Atributos { get; init; }


        public ConjuntoAtributosVO( int valorForca, int valorDestreza, int valorConstituicao, int valorSabedoria, int valorPresenca, int valorVontade) {

            this.Atributos = ImplementarAtributos(valorForca, valorDestreza, valorConstituicao, valorSabedoria, valorPresenca, valorVontade);
        }


        private List<AtributoVO> ImplementarAtributos(int valorForca, int valorDestreza, int valorConstituicao, int valorSabedoria, int valorPresenca, int valorVontade)
        {

            var atributos = new List<AtributoVO>()
            {
                 new AtributoVO(AtributosEnum.FORCA,valorForca),
                 new AtributoVO(AtributosEnum.DESTREZA,valorDestreza),
                 new AtributoVO(AtributosEnum.CONSTITUICAO,valorConstituicao),
                 new AtributoVO(AtributosEnum.SABEDORIA,valorSabedoria),
                 new AtributoVO(AtributosEnum.PRESENCA,valorPresenca),
                 new AtributoVO(AtributosEnum.VONTADE, valorVontade)
              
            };



            return atributos;
        }


        public ConjuntoAtributosVO AlterarAtributos(List<AtributoVO> novosAtributos)
        {
            if (novosAtributos == null)
            {
                return this;
            }

            int forca = novosAtributos.Find(p => p.Nome == AtributosEnum.FORCA ).ValorBase;
            int destreza = novosAtributos.Find(p => p.Nome == AtributosEnum.DESTREZA).ValorBase;
            int constituicao = novosAtributos.Find(p => p.Nome == AtributosEnum.CONSTITUICAO).ValorBase;
            int sabedoria = novosAtributos.Find(p=> p.Nome == AtributosEnum.SABEDORIA).ValorBase;
            int presenca = novosAtributos.Find(p => p.Nome == AtributosEnum.PRESENCA).ValorBase;
            int vontade = novosAtributos.Find(p => p.Nome == AtributosEnum.VONTADE).ValorBase;

           
            

            return new ConjuntoAtributosVO(forca,destreza,constituicao,sabedoria,presenca,vontade);
        }

        public ConjuntoAtributosVO AlterarAtributoUnico(AtributoVO novosAtributos)
        {
            if (novosAtributos == null)
            {
                return this;
            }

            int forca = Atributos.Find(p => p.Nome == AtributosEnum.FORCA).ValorBase;
            int destreza = Atributos.Find(p => p.Nome == AtributosEnum.DESTREZA).ValorBase;
            int constituicao = Atributos.Find(p => p.Nome == AtributosEnum.CONSTITUICAO).ValorBase;
            int sabedoria = Atributos.Find(p => p.Nome == AtributosEnum.SABEDORIA).ValorBase;
            int presenca = Atributos.Find(p => p.Nome == AtributosEnum.PRESENCA).ValorBase;
            int vontade = Atributos.Find(p => p.Nome == AtributosEnum.VONTADE).ValorBase;


            switch (novosAtributos.Nome)
            {
                case AtributosEnum.FORCA:
                    forca = novosAtributos.ValorBase;
                    break;
                case AtributosEnum.DESTREZA:
                    destreza = novosAtributos.ValorBase;
                    break;
                case AtributosEnum.CONSTITUICAO:
                    constituicao = novosAtributos.ValorBase;
                    break;
                case AtributosEnum.SABEDORIA:
                    sabedoria = novosAtributos.ValorBase;
                    break;
                case AtributosEnum.PRESENCA:
                    presenca = novosAtributos.ValorBase;
                    break;
                case AtributosEnum.VONTADE:
                    vontade = novosAtributos.ValorBase;
                    break;



            }





            return new ConjuntoAtributosVO(forca, destreza, constituicao, sabedoria, presenca, vontade);
        }

    }
}
