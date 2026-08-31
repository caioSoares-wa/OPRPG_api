using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    internal record DeslocamentoVO
    {
        public int Terra { get; init; } = 0;
        public int Voo { get; init; } = 0;
        public int Nado { get; init; } = 0;
    }
}
