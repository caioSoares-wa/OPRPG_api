using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EstilosDeCombateVOs
{
    public  record EstilosDeCombateAtributoPrimarioVO
    {
        public List<AtributosEnum> AtributoPrimario { get; init; } = new();
    }
}
