using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record EspeciesVarianteDaEspecieVO
    {
        public string Descricao { get; init; } = string.Empty;
        public List<EspeciesVarianteDaEspecieOpcoesVO>? Opcoes { get; init; }
    }
}
