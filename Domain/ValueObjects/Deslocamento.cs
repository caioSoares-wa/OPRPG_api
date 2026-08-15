using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects
{
    internal class Deslocamento
    {
        public int Terra { get; set; } = 0;
        public int Voo { get; set; } = 0;
        public int Nado { get; set; } = 0;
    }
}
