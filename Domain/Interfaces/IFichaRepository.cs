using Domain.ValueObjects.AtributosVOs;
using Domain.ValueObjects.EstilosDeCombateVOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IFichaRepository
    {
        public ConjuntoAtributosVO CriarAtributos(int valorForca, int valorDestreza, int valorConstituicao, int valorSabedoria, int valorPresenca, int valorVontade);

        public EstilosDeCombateVO EscolherEstilo();
    }
}
