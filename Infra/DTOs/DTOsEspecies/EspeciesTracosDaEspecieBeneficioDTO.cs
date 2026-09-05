using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DTOs.DTosEspecies
{
    public record EspeciesTracosDaEspecieBeneficioDTO
    {
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
    }
}
