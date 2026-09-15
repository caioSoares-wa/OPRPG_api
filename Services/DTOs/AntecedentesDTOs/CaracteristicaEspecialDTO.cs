using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs.AntecedentesDTOs
{
    public record CaracteristicaEspecialDTO
    {
        public string Nome { get; init; } = string.Empty;
        public string Descricao { get; init; } = string.Empty;
    }
}
