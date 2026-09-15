using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.SubEntities.Especies
{
    public record VarianteDaEspecie
    {
        public string Descricao { get; init; } = string.Empty;
        public List<VarianteOpcoes> Opcoes { get; init; }

    }
}
