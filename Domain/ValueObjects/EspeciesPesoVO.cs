using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record EspeciesPesoVO
    {
        public string Faixa { get; init; } = string.Empty;
    }
}
