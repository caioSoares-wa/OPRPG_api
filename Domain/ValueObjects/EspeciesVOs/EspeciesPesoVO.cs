using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EspeciesVOs
{
    public record EspeciesPesoVO
    {
        public string Faixa { get; init; } = string.Empty;
    }
}
