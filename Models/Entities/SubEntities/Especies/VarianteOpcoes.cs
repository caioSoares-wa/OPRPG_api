using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.SubEntities.Especies
{

    public record VarianteOpcoes
    {
        public string Nome { get; init; } = string.Empty;
        public VarianteBeneficios Beneficio { get; init; }
    }
}