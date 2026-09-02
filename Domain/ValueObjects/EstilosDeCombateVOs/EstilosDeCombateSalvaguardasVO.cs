using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EstilosDeCombateVOs
{
    public record EstilosDeCombateSalvaguardasVO
    {
        public List<AtributosEnum> Salvaguardas { get; init; } = new();
    }

}
