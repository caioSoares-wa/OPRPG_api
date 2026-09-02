using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EstilosDeCombateVOs
{
    public record EstiloDeCombateArmaFavoritaVO
    {
        public string Descricao { get; init; } = string.Empty;

        public List<string> Opcoes { get; init; }

        public bool PermiteCorporal { get; init; }


    }
}
