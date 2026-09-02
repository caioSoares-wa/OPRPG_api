using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EspeciesVOs
{
    public record EspeciesAncestralidadeVO
    {
        public string Descricao { get; init; } = string.Empty;
    }
}
