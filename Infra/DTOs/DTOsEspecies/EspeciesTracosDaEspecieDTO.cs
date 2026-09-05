using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DTOs.DTosEspecies
{
    public class EspeciesTracosDaEspecieDTO
    {
        public List<EspeciesTracosDaEspecieBeneficioDTO> Beneficios { get; init; }
        public List<EspeciesDificuldadesDTO> Dificuldades { get; init; }
    }
}
