using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs.EspeciesDTOs
{
    public record RegrasEspeciais
    {
        public string Nome { get; init; } = string.Empty;
        public string Descricao { get; init; } = string.Empty;
    }
}
