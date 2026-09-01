using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record EspeciesAncestralidadeVO
    {
        public string Descricao { get; init; } = string.Empty;
    }
}
