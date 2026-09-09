using Domain.Interfaces;
using Domain.ValueObjects.AtributosVOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases
{
    public class FichaUseCase
    {
        private readonly IFichaRepository fichaRepository;

        public FichaUseCase(IFichaRepository ficha)
        {
            fichaRepository = ficha;
        }



        public  ConjuntoAtributosVO CriarAtributos(int valorForca, int valorDestreza, int valorConstituicao, int valorSabedoria, int valorPresenca, int valorVontade)
        {

            var result =  fichaRepository.CriarAtributos(valorForca, valorDestreza, valorConstituicao, valorSabedoria, valorPresenca, valorVontade);


            if (result == null)
            {
                throw new NullReferenceException("Atributos Nulos");
            }


            return result;
        }
    }
}
