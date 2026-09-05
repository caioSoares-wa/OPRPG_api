using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.ValueObjects.EspeciesVOs
{
    public record EspeciesTracosDaEspecieBeneficioVO
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}
