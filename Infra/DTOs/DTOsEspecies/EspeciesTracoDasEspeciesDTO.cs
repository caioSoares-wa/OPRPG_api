using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.DTOs.DTosEspecies
{
    public class EspeciesTracoDasEspeciesDTO
    {
        public List<EspeciesTracoDasEspeciesBeneficioDTO> Beneficios { get; init; }
        public List<EspeciesDificuldadesDTO> Dificuldades { get; init; }
    }
}
