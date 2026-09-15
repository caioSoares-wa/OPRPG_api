using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.SubEntities.Antecedentes
{
    public record CaracteristicaEspecial
    {
        public string Nome { get; init; } = string.Empty;
        public string Descricao { get; init; } = string.Empty;
    }
}
