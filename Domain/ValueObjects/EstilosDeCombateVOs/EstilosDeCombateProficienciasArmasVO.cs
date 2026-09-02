using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EstilosDeCombateVOs
{
    public record EstilosDeCombateProficienciasArmasVO
    {
        public List<string> ProficienciaArmas { get; init; } = new ();
    }
}
