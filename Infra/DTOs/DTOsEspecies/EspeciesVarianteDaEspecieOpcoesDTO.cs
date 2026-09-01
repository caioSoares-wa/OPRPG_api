using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DTOs.DTosEspecies
{
    public record EspeciesVarianteDaEspecieOpcoesDTO
    {
        public string Nome { get; init; } = string.Empty;
        public EspeciesVarianteDaEspecieOpcoesBeneficiosDTO? Beneficios { get; init; }
    }
}
