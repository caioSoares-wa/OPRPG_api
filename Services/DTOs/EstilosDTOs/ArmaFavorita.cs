using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs.EstilosDTOs
{
    public record ArmaFavorita
    {
        public string Descricao { get; init; }
        public List<string> Opcoes { get; init; }
        public bool PermiteCorporal { get; init; }

    }
}
