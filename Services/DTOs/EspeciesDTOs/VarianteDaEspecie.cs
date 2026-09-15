using System;
using System.Collections.Generic;
using System.Text;

namespace Services.DTOs.EspeciesDTOs
{
    public record VarianteDaEspecie
    {
        public string Descricao { get; init; } = string.Empty;
        public List<VarianteOpcoes> Opcoes { get; init; }

    }
}
