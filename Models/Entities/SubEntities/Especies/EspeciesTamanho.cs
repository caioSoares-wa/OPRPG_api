using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Entities.SubEntities.Especies
{
    public  record EspeciesTamanho
    {
        public string Categoria { get; init; } = string.Empty;
        public string Faixa { get; init; } = string.Empty;
    }
}
