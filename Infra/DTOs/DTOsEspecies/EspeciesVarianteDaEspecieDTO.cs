using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DTOs.DTosEspecies
{
    public record EspeciesVarianteDaEspecieDTO
    {
        public string Descricao { get; init; } = string.Empty;
        public List<EspeciesVarianteDaEspecieOpcoesDTO>? Opcoes { get; init; }
    }
}
