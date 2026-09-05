using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EspeciesVOs
{
    public record EspeciesVarianteDaEspecieOpcoesVO
    {
        public string Nome { get; init; } = string.Empty;
        public EspeciesVarianteDaEspecieOpcoesBeneficiosVO? Beneficio { get; init; }
    }
}
