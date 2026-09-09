using Domain.Interfaces;
using Domain.ValueObjects.AtributosVOs;
using Domain.ValueObjects.EstilosDeCombateVOs;
using Infra.DTOs.DTOsConjuntoAtributos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Services
{
    public class FichaRepository : IFichaRepository
    {


        public  ConjuntoAtributosVO CriarAtributos(int valorForca, int valorDestreza, int valorConstituicao, int valorSabedoria, int valorPresenca, int valorVontade)
        {
           
            var conjunto = new ConjuntoAtributosVO(
                valorForca,
                valorDestreza,
                valorConstituicao,
                valorSabedoria,
                valorPresenca,
                valorVontade
                );
            return conjunto;
        }

        public EstilosDeCombateVO EscolherEstilo()
        {
            throw new NotImplementedException();
        }
    }
}
