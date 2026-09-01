using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record EspeciesTracoDasEspeciesBeneficioVO
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}
