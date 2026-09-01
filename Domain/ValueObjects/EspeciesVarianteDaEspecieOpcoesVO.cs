using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record EspeciesVarianteDaEspecieOpcoesVO
    {
        public string Nome { get; init; } = string.Empty;
        public EspeciesVarianteDaEspecieOpcoesBeneficiosVO? Beneficios { get; init; }
    }
}
