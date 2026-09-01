using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    public record EspeciesDificuldadesVO
    {
        public string Nome { get; init; } = string.Empty;
        public string Descricao { get; init; } = string.Empty;
    }
}
