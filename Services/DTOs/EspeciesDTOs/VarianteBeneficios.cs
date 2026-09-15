using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs.EspeciesDTOs
{
    public record VarianteBeneficios
    {
        public string Nome { get; init; }  = string.Empty;
        public string Descricao { get; init; } = string.Empty;

    }
}
