using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EstilosDeCombateVOs
{
    public record EstilosDeCombateVO
    {

        public EstiloDeCombateRegrasGeraisVO RegrasGerais { get; init; }
        public List<EstilosDeCombateEstilosVO> Estilos { get; init; }



    }
}
