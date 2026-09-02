using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EstilosDeCombateVOs
{
    public record EstiloDeCombateProficienciaPericiasVO
    {
        public string Descricao { get; init; } = string.Empty;
        public List<PericiasEnum>? Opcoes { get; init; }
        public int Quantidade { get; init; }

    }
}
